---
title: "Using Hugo Static Site Generater"
date: 2019-03-25T12:07:00-04:00
draft: true
tags: [About, Hugo, Static Site Generater, Firebase]
series: Site Update
---
Blogging since 2011~ In 2011, I was implementing a [WordPress](https://wordpress.org) site for the company I worked with. I liked the mix of easy and complex that is available with WordPress. You can very easily install and activate a theme and start building a web site. Customization is possible, which I had to do for my work project by writing PHP and creating plugins. 

I continued using WordPress until this year (2019), I heard a friend talking about _Static Site Generators_ and was intrigued. I looked at [Wyam.io](https://www.wyam.io) initially and was able to quickly build a personal blog with it. Wyam is a .NET Core application that takes Markdown and generates an HTML site. This is the basis for all Static Site Generators. There is no server side code running, so hosting the site becomes very easy and low cost.

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





