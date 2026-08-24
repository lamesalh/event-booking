// Write your JavaScript code.

let isMoving = false;

function moveSlide(carouselId, direction) {
  if (isMoving) return;
  isMoving = true;

  const track = document.getElementById(`${carouselId}-track`);
  if (!track) {
    console.error(`Carousel track with ID '${carouselId}-track' not found.`);
    return;
  }

  const items = track.querySelectorAll('.carousel-item');
  const itemWidth = items[0]?.offsetWidth + 20 || 0;

  track.style.transition = 'transform 0.5s ease-in-out';

  if (direction === 1) {
    track.style.transform = `translateX(-${itemWidth}px)`;
    setTimeout(() => {
      track.appendChild(track.firstElementChild);
      track.style.transition = 'none';
      track.style.transform = 'translateX(0)';
      isMoving = false;
    }, 500);
  } else if (direction === -1) {
    track.insertBefore(track.lastElementChild, track.firstElementChild);
    track.style.transition = 'none';
    track.style.transform = `translateX(-${itemWidth}px)`;
    setTimeout(() => {
      track.style.transition = 'transform 0.5s ease-in-out';
      track.style.transform = 'translateX(0)';
      isMoving = false;
    }, 50);
  }
}

// Auto Scroll with Pause on Hover
const carousel = document.querySelector('.carousel-wrapper');
if (carousel) {
  let autoScroll = setInterval(() => moveSlide('concerts', 1), 4000);

  carousel.addEventListener('mouseover', () => clearInterval(autoScroll));
  carousel.addEventListener('mouseleave', () => {
    autoScroll = setInterval(() => moveSlide('concerts', 1), 4000);
  });
}

// Theme Switch
const toggleSwitch = document.querySelector('.theme-switch input[type="checkbox"]');
if (toggleSwitch) {
  toggleSwitch.addEventListener('change', (e) => {
    const theme = e.target.checked ? 'dark' : 'light';
    document.documentElement.setAttribute('data-theme', theme);
  });
}

// Contact Form Validation
const popupMessage = document.getElementById('popup-message');
const closePopup = document.getElementById('close-popup');
const nameInput = document.getElementById('name');
const emailInput = document.getElementById('email');
const messageInput = document.getElementById('message');
const contactForm = document.getElementById('contact-form');
const errorElement = document.createElement('p'); 
errorElement.id = 'error';
if (contactForm) {
  contactForm.appendChild(errorElement); 
}

const submitBtn = document.getElementById('submit');

if (submitBtn && contactForm) {
  submitBtn.addEventListener('click', (e) => {
    e.preventDefault();

    errorElement.innerHTML = '';

    // Validate Name
    if (nameInput?.value.trim().length < 3) {
      errorElement.innerHTML = 'Your name should be at least 3 characters long.';
      return;
    }

    // Validate Email
    const emailValid = /^[^\s@]+@[^\s@]+\.[^\s@]+$/.test(emailInput?.value);
    if (!emailValid) {
      errorElement.innerHTML = 'Please enter a valid email address.';
      return;
    }

    // Validate Message
    if (messageInput?.value.trim().length < 15) {
      errorElement.innerHTML = 'Please write a longer message.';
      return;
    }

    // Success: Show popup and clear form
    popupMessage?.classList.remove('hidden'); // Show popup
    setTimeout(() => {
      contactForm.reset(); // Clear form fields
    }, 500);
  });
}

// Close Popup
if (closePopup) {
  closePopup.addEventListener('click', () => {
    popupMessage?.classList.add('hidden'); // Hide popup
  });
}
