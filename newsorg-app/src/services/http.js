import axios from "axios";

const source = axios.CancelToken.source();
//https://localhost:44393/Article/GetTopHeadlines
const instance = axios.create({
  baseURL: "http://localhost:62235/",
  timeout: 30000,
  // headers: {
  //   "Cross-Origin-Embedder-Policy": "require-corp",
  //   "Cross-Origin-Opener-Policy": "same-origin",
  // },
  cancelToken: source.token,
});

instance.interceptors.response.use(
  (response) => response,
  (error) => {
    if (axios.isCancel(error)) {
      console.log("Request canceled", error.mesage);
      return Promise.reject(null);
    }

    return Promise.reject(error);
  }
);

const getHeadLines = (page) => {
  const url = page ? `Article/Get${page}` : "Article/GetTopHeadlines";
  return instance.get(url);
};
const $cancel = () => source.cancel();

export { getHeadLines, $cancel };
