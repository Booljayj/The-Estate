---
title: Locations
category: main
---

{% for page in site.pages %}
{% if page.category == "location" %}
[{{ page.title }}]({{ site.baseurl }}{{ page.url }})
{% endif %}
{% endfor %}