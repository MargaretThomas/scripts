// Select all the <a> elements within ytd-channel-renderer elements
const channelLinks = document.querySelectorAll('ytd-channel-renderer a.channel-link');

// Iterate through each link and open it in a new tab
channelLinks.forEach(link => {
    const href = link.href;
    if (href) {
        window.open(href, '_blank');
    }
});

console.log(`${channelLinks.length} YouTube channel links opened in new tabs.`);
