# RiskAPI — Domain Risk Score API (Examples)

RiskAPI returns a deterministic risk score for a domain based on public technical signals.

- Pricing: https://riskapi.analyses-web.com/pricing.html
- Docs: https://riskapi.analyses-web.com/docs
- OpenAPI: https://riskapi.analyses-web.com/openapi

## Quick start (curl)

curl -sS -H "X-API-Key: YOUR_API_KEY" -H "Content-Type: application/json" -d '{"url":"https://example.com"}' https://riskapi.analyses-web.com/risk-score

## Check usage / quota

curl -sS -H "X-API-Key: YOUR_API_KEY" https://riskapi.analyses-web.com/usage

## Explain mode

curl -sS -H "X-API-Key: YOUR_API_KEY" -H "Content-Type: application/json" -d '{"url":"https://example.com"}' "https://riskapi.analyses-web.com/risk-score?explain=1"

## Example response (explain=false)
{"riskScore":0,"riskLevel":"low","signals":["long_or_hyphenated_domain","dns_dmarc_policy_none","dns_caa_missing","recent_rdap_update_rdap_db"],"version":"v2.1","meta":{"cached":true,"processingMs":0,"requestId":"...","cacheHours":24,"scoringPolicy":"2026-01"}}

## Example response (explain=true)
{"riskScore":0,"riskLevel":"low","signals":["long_or_hyphenated_domain","dns_dmarc_policy_none","dns_caa_missing","recent_rdap_update_rdap_db"],"version":"v2.1","meta":{"cached":true,"processingMs":0,"requestId":"...","cacheHours":24,"scoringPolicy":"2026-01"},"explanations":[{"signal":"long_or_hyphenated_domain","severity":"info","category":"informational","note":"Long domain or multiple hyphens: weak heuristic (frequent false positives)."},{"signal":"dns_dmarc_policy_none","severity":"info","category":"informational","note":"DMARC p=none: monitoring mode (less protective)."},{"signal":"dns_caa_missing","severity":"info","category":"informational","note":"CAA missing: very common; not meaningful on its own."},{"signal":"recent_rdap_update_rdap_db","severity":"info","category":"informational","note":"RDAP: RDAP DB update (often registry maintenance; noisy)."}]}

## Postman collection

Set YOUR_API_KEY in your Postman environment before sending requests.

https://www.postman.com/rene-ronse-6794962/public/collection/51072655-1fb9e4f2-dcfb-436b-a6e2-be4a56d228a3
