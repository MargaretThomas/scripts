# Netflix Ratings Extractor
### Getting started

The purpose of this script is to extract all the ratings on your Netflix profile at [Viewing Activity](https://www.netflix.com/settings/viewed/)

To run the script, go to the Viewing Activity page, open dev tools and paste the code in the console. The response will be in json. Here is an example of what you will see.

```
[
	{
		"date": "24/07/16",
		"title": "Forgive Us Our Trespasses",
		"icon": "ThumbsUpFillStandard"
	},
	{
		"date": "24/07/10",
		"title": "Hello, Me!",
		"icon": "ThumbsUpTwoFillStandard"
	},
	{
		"date": "24/03/26",
		"title": "An Incurable Case of Love",
		"icon": "ThumbsDownFillStandard"
	},
	{
		"date": "24/03/05",
		"title": "Pinocchio",
		"icon": "ThumbsDownFillStandard"
	}
]
```

#### File descriptions
```Prompt.md``` contains the prompt used to ask ChatGPT to generate the script.
```Generated code.js``` contains the JavaScript code which you can run in your browser.