import React from "react";
import Slider from "react-slick";
import NewsHeroItem from "../news-hero-item";

import NewsCardItem from "../news-card-item";

export default function NewsHero({ headlines }) {
  const sliderNews = headlines
    .slice(0, 3)
    .map((article, index) => <NewsHeroItem article={article} key={index} />);

  return (
    <React.Fragment>
      <Slider
        lazyLoad={true}
        arrows={false}
        children={sliderNews}
        dots={true}
        speed={800}
        pauseOnDotsHover={false}
        pauseOnHover={false}
        pauseOnFocus={false}
        swipeToSlide={true}
        autoplaySpeed={10000}
        autoplay={true}
      />
      <NewsCardItem headlines={headlines.slice(3, headlines.length)} />
    </React.Fragment>
  );
}
