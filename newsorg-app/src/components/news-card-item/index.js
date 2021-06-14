import React from "react";

import GridList from "@material-ui/core/GridList";
import GridListTile from "@material-ui/core/GridListTile";
import GridListTileBar from "@material-ui/core/GridListTileBar";
import ListSubheader from "@material-ui/core/ListSubheader";
import IconButton from "@material-ui/core/IconButton";
import InfoIcon from "@material-ui/icons/Info";

import "./styles.css";

export default function NewsCardItem({ headlines }) {
  return (
    <React.Fragment>
      <GridList cellHeight={180} className="grid-list">
        <GridListTile key="Subheader" cols={2} style={{ height: "auto" }}>
          <ListSubheader component="div"></ListSubheader>
        </GridListTile>
        {headlines.map((article) => (
          <GridListTile key={article.urltoImage}>
            <img src={article.urltoImage} alt={article.title} />
            <GridListTileBar
              title={article.title}
              subtitle={<span>by: {article.sourceName}</span>}
              actionIcon={
                <IconButton className="icon" href={article.url} target="_blank">
                  <InfoIcon />
                </IconButton>
              }
            />
          </GridListTile>
        ))}
      </GridList>
    </React.Fragment>
  );
}
