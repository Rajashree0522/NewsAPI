import React from "react";
import moment from "moment";
import click from "../../assets/images/click.png";

export default function NewsHeroItem({ article }) {
  const time = moment(article.publishedAt).fromNow();
  const imageURL = article.urlToImage
    ? article.urlToImage
    : "https://via.placeholder.com/1920x1080/22222/FFFFFF/?text=No+Image";

  return (
    <div style={{ backgroundImage: `url(${imageURL})` }} className="main-hero">
      <div className="overlay">
        <div className="content">
          <h2>{article.title}</h2>
          <p>{article.description}</p>
          <span className="source">{article.sourceName}</span>
          <span className="time">{time}</span>
        </div>
        <div className="reactions-container">
          <a rel="noopener noreferrer" target="_blank" href={article.url}>
            <img src={click} alt="button" />
          </a>
        </div>
      </div>
    </div>
  );
}
