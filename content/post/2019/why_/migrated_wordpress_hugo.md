---
title: "Why Migratee from WordPress to Hugo"
date: 2019-03-25T12:07:00-04:00
draft: true
tags: [About, Hugo, Static Site Generater, Firebase]
series: Site Update
---
I have been using [WordPress] for a long time and could easily sping up a new site, customize it and get it where I wanted quickly. After seeing talk of _Static Site Generators_, and looking at [Wyam.io](https://wyam.io) and then [Hugo](htttp://www.gohugo.io) I knew I wanted to switch to a Static Site Generator and decied on Hogo.

## Why Hugo?
I was very impressed with how well Hugo is documented and the foundation it has that I wanted to investigate more. Creating a new site with one of the many themes was very simple. You have to be familiar and comfortabl with command line though. Once again, I went back to the documentation and the active community group and found answers to my questions.

As I looked more, I found [Hugo](https://gohugo.io) and decided to move to Hugo and that is where I am at now.

## Why Static Site
A static site provides a huge performance increase of server side web sites. There is no server side processing on the web server which provides the performance gain. The site is all html, images and css. Pages are cached to increase the performance more.

Hosting a static site is very easy, any web hosting will work for static pages. There is no requirement to make sure the hosting provider handles .NET, PHP or any other server side language.

This opens you up to using Blob storage for hosting static sites which great decreases the cost of hosting.

This is a personal site and lower cost is **ALWAYS** good. Right now my site hosting is free with Google Firebase Hosting, if my site gets heavy use then price will increase but no where near the cost of _normal_ hosting package. For example, I was hosting for about $20 a month and now my cost is FREE.

## Why Markdown
I have been using Markdown for some time now, I use Markdown in my personal journal as well as when I am taking notes. With Markdown you focus on your writing with a basic text editor and apply some simple syntax that can be converted into other formats (in this case HTML). Markdown can be converted to PDF files and many other formats.

Markdown provides a separation of design from content. This provides a nice workflow for creating and editing content on a web site.

### Front Matter
A concept known as _Front Matter_ is used with Markdown and Static Site Generators. Front Matter contains meta data about the content and can be included with every Markdown file.

```md
---
title: "Using Hugo Static Site Generater"
date: 2019-03-25T12:07:00-04:00
draft: true
tags: [About, Hugo, Static Site Generater, Firebase]
---
```
The snippet above shows the Front Matter for this post. The information in the Markdown is used by the generator to build out the web site. Front Matter can be customized with new meta data and then used in templates to handle the meta data. For example, I will be adding additional information to the Front Matter for a feature image. This will allow the feature image to be specified in the Front Matter and then used for a thumbnail on a list page.

## Why Hugo?
[Hugo](https://gohugo.io) is written in the [Go language](https://golang.org) and has great documentation and a very active community. Hugo also have a large selection of themes to choose from.

After reading the documentation and looking at the available themes, I decided this is the way for me to go. I choose the theme [PaperCss] which I felt was the perfect look for this site.

I am a principal engineer, which means I design architectures for systems. With this site, I wanted to be able to focus on content and sharing what I am learning. Using Markdown and Hugo makes this very easy and also provides me the option of customizing without a huge amount of effort. _Unless, of course I want to put the time in and really customize a site._

## Source Control
All of the site is stored on GitHub, which provides a nice workflow for tracking changes and opening up to continuous integration and deployment (I am not there yet...).

### Contributors
I don’t have any contributors but am open to having others contribute to this blog. This becomes very easy, I create a branch from GitHub and have someone start creating a post. The post is in source control and I can control if it is merged into “master” where the site is published.
