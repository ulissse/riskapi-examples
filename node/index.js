const API_KEY = process.env.YOUR_API_KEY;

async function main() {
  if (!API_KEY) {
    console.error("Missing env var: YOUR_API_KEY");
    process.exit(1);
  }

  const r = await fetch("https://riskapi.analyses-web.com/risk-score", {
    method: "POST",
    headers: {
      "X-API-Key": API_KEY,
      "Content-Type": "application/json",
    },
    body: JSON.stringify({ url: "https://example.com" }),
  });

  console.log(await r.text());
}

main().catch(console.error);
