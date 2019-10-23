# Practice test doubles
Use libraries as NSubstitue if you need doubles.

## Exercises
1. EmojiSales Renderer. This class uses a service that returns the daily sales, and depending of the value, renders an emoji ";)".
  a) Fix tests in class EmojiSalesRendererTests. They must be reliable.
  b) Cover all test cases of EmojiSalesRenderer.

2. SalesNotifier. A mailing notifier that alerts to a mailing account when alerts are bad or are pretty good.
  a) When sales are below 10, a mail alert is sent with subject "Bad sales"
  b) When sales are over 25, a mail alert is sent with subject "Good sales"
