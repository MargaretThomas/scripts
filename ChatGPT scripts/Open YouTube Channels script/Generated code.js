// Get all the channel links from ytd-channel-renderer elements
const channelLinks = document.querySelectorAll('ytd-channel-renderer a.channel-link');

// Create a Set to store unique URLs
const uniqueUrls = new Set();

// Iterate through each link and add its href to the Set
channelLinks.forEach(link => {
    uniqueUrls.add(link.href);
});

// Open each unique URL in a new tab
uniqueUrls.forEach(url => {
    window.open(url, '_blank');
});

