// auth.js - Handles OAuth SSO events

document.getElementById("loginApple").addEventListener("click", function () {
  // Redirect to backend endpoint for Apple OAuth (placeholder)
  window.location.href = "/api/auth/apple";
});

document
  .getElementById("loginMicrosoft")
  .addEventListener("click", function () {
    // Redirect to backend endpoint for Microsoft OAuth
    window.location.href = "/api/auth/microsoft";
  });

document.getElementById("loginGoogle").addEventListener("click", function () {
  // Redirect to backend endpoint for Google OAuth
  window.location.href = "/api/auth/google";
});
