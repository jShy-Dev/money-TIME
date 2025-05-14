// app.js - Main frontend functionality (calendar view, toggles, etc.)

document.addEventListener("DOMContentLoaded", function () {
  let loginContainer = document.getElementById("login-container");
  let calendarContainer = document.getElementById("calendar-container");

  // Dummy function to simulate login success
  function loginSuccess() {
    loginContainer.style.display = "none";
    calendarContainer.style.display = "block";
    loadCalendar();
  }

  // For testing, simulate successful login if URL contains a token query parameter
  if (window.location.search.indexOf("token") > -1) {
    loginSuccess();
  }

  function loadCalendar() {
    let calendar = document.getElementById("calendar");
    calendar.innerHTML = "<h2>Monthly Calendar View</h2>";
    // Generate a basic calendar grid (placeholder)
    for (let i = 1; i <= 30; i++) {
      let dayTile = document.createElement("div");
      dayTile.className = "day-tile";
      dayTile.textContent = i;
      dayTile.addEventListener("click", function () {
        // Open daily breakdown view (placeholder)
        alert("Day " + i + " details");
      });
      calendar.appendChild(dayTile);
    }
  }
});
