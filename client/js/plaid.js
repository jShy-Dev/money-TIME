// plaid.js - Handles Plaid integration for bank account linking

function openPlaidLink() {
  // Example using Plaid Link SDK
  var handler = Plaid.create({
    clientName: "BudgetApp-MVP",
    env: "sandbox", // Change to 'production' when live
    key: "YOUR_PLAID_PUBLIC_KEY",
    product: ["transactions"],
    onSuccess: function (public_token, metadata) {
      // Send the public_token to your backend to exchange for an access token
      console.log("Plaid success:", public_token, metadata);
      fetch("/api/plaid/exchange", {
        method: "POST",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify({ public_token }),
      })
        .then((response) => response.json())
        .then((data) => {
          console.log("Bank account linked!", data);
        });
    },
    onExit: function (err, metadata) {
      console.error("Plaid exit:", err, metadata);
    },
  });
  handler.open();
}
