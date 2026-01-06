import os
import requests

api_key = os.environ.get("YOUR_API_KEY")
if not api_key:
    raise SystemExit("Missing env var: YOUR_API_KEY")

r = requests.post(
    "https://riskapi.analyses-web.com/risk-score",
    headers={"X-API-Key": api_key},
    json={"url": "https://example.com"},
    timeout=20,
)
print(r.text)
