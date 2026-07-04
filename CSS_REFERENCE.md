# Bootstrap Classes & Custom CSS Reference

## Overview

This document provides a complete reference of all Bootstrap 5 classes and custom CSS used in the improved Tickets component.

---

## Bootstrap Classes Used

### Layout & Grid

```html
.container-fluid        <!-- Full-width container -->
.row                    <!-- Grid row -->
.col-md-6               <!-- 6 columns on medium screens -->
.col-lg-4               <!-- 4 columns on large screens (3 cards per row) -->
.g-3                    <!-- Grid gap (16px) -->
.gap-2                  <!-- Flexbox gap (8px) -->
```

### Flexbox Utilities

```html
.d-flex                 <!-- Display: flex -->
.justify-content-between <!-- Space-between alignment -->
.justify-content-center <!-- Center alignment -->
.align-items-center     <!-- Vertical center alignment -->
.flex-grow-1            <!-- Grow to fill available space -->
.flex-column            <!-- Flex column direction -->
```

### Cards

```html
.card                   <!-- Card container -->
.card-header            <!-- Card header section -->
.card-body              <!-- Card body/content -->
.card-title             <!-- Card title -->
.card-text              <!-- Card text/paragraph -->
.shadow-sm              <!-- Subtle shadow (0.125rem) -->
.h-100                  <!-- Height 100% (full height) -->
```

### Typography & Text

```html
.page-title             <!-- CUSTOM: Page title styling -->
.text-muted             <!-- Muted/gray text color -->
.text-white             <!-- White text -->
.text-dark              <!-- Dark text (for yellow background) -->
.text-danger            <!-- Danger red text -->
.text-center            <!-- Center text alignment -->
.mb-0                   <!-- Margin bottom 0 -->
.mb-2                   <!-- Margin bottom 0.5rem -->
.mb-3                   <!-- Margin bottom 1rem -->
.mb-4                   <!-- Margin bottom 1.5rem -->
.mt-auto                <!-- Margin top auto (pushes down) -->
.p-*                    <!-- Padding utilities -->
.py-5                   <!-- Vertical padding 3rem -->
```

### Badges

```html
.badge                  <!-- Badge component -->
.bg-primary             <!-- Primary blue background -->
.bg-success             <!-- Success green background -->
.bg-danger              <!-- Danger red background -->
.bg-warning             <!-- Warning yellow background -->
.bg-info                <!-- Info light blue background -->
.bg-secondary           <!-- Secondary gray background -->
```

### Forms & Inputs

```html
.form-label             <!-- Form label styling -->
.form-control           <!-- Text input styling -->
.form-select            <!-- Dropdown/select styling -->
.form-group             <!-- Form field container -->
```

### Buttons

```html
.btn                    <!-- Button base class -->
.btn-primary            <!-- Primary button (blue) -->
.btn-secondary          <!-- Secondary button (gray) -->
.btn-danger             <!-- Danger button (red) -->
.btn-outline-primary    <!-- Outlined primary button -->
.btn-outline-secondary  <!-- Outlined secondary button -->
.btn-sm                 <!-- Small button size -->
```

### Alerts & Messages

```html
.alert                  <!-- Alert box container -->
.alert-info             <!-- Info alert (blue) -->
```

### Pagination

```html
.pagination             <!-- Pagination container -->
.page-item              <!-- Pagination item -->
.page-link              <!-- Pagination link -->
.active                 <!-- Active pagination item -->
.disabled               <!-- Disabled pagination item -->
```

### Background & Colors

```html
.bg-primary             <!-- Primary blue background -->
.bg-secondary           <!-- Secondary gray background -->
.bg-success             <!-- Success green background -->
.bg-danger              <!-- Danger red background -->
.bg-warning             <!-- Warning yellow background -->
.bg-info                <!-- Info blue background -->
```

---

## Custom CSS Classes

### Page Header
```css
.page-header {
	border-bottom: 2px solid #f0f0f0;
	padding-bottom: 1rem;
}
```

### Page Title
```css
.page-title {
	font-size: 2rem;
	font-weight: 600;
	color: #333;
	margin: 0;
}
```

### Ticket Card
```css
.ticket-card {
	transition: all 0.3s ease;
	border: 1px solid #e0e0e0;
}

.ticket-card:hover {
	transform: translateY(-4px);
	box-shadow: 0 8px 16px rgba(0, 0, 0, 0.1) !important;
	border-color: #1b6ec2;
}
```

### Card Header
```css
.card-header {
	font-weight: 600;
	border-bottom: 1px solid rgba(0, 0, 0, 0.1);
}
```

### Toast Container
```css
.toast-container {
	position: fixed;
	bottom: 20px;
	right: 20px;
	padding: 12px 18px;
	border-radius: 8px;
	color: white;
	font-weight: 500;
	z-index: 9999;
	box-shadow: 0 4px 12px rgba(0,0,0,0.2);
	animation: fadein 0.3s ease-in-out;
}

.toast-container.success {
	background-color: #28a745;
}

.toast-container.error {
	background-color: #dc3545;
}
```

---

## CSS Color Scheme

### Status Colors
```
Open       → bg-danger (#dc3545, red)
InProgress → bg-warning (#ffc107, yellow)
Closed     → bg-success (#28a745, green)
```

### Priority Colors
```
Low        → bg-info (#0dcaf0, light blue)
Medium     → bg-warning (#ffc107, yellow)
High       → bg-danger (#dc3545, red)
```

### Semantic Colors
```
Primary    → #1b6ec2 (blue)
Secondary  → #6c757d (gray)
Success    → #28a745 (green)
Danger     → #dc3545 (red)
Warning    → #ffc107 (yellow)
Info       → #0dcaf0 (cyan)
```

---

## Responsive Design

### Breakpoints
```css
/* Extra small devices (phones, less than 576px) */
/* No prefix: default styles */

/* Small devices (landscape phones, 576px and up) */
@media (min-width: 576px) { ... }

/* Medium devices (tablets, 768px and up) */
@media (min-width: 768px) { ... }

/* Large devices (desktops, 992px and up) */
@media (min-width: 992px) { ... }

/* Extra large devices (large desktops, 1200px and up) */
@media (min-width: 1200px) { ... }

/* XXL (1400px and up) */
@media (min-width: 1400px) { ... }
```

### Our Implementation
```css
/* Mobile (< 768px) */
Default layout applies
Cards stack vertically

/* Tablet (768px - 1200px) */
@media (max-width: 768px)
Forms stack vertically
2 cards per row (col-md-6)

/* Desktop (> 1200px) */
Forms side-by-side
3 cards per row (col-lg-4)
```

---

## Spacing Scale

Bootstrap uses a 6px scale:

```
0    = 0rem    = 0px
1    = 0.25rem = 4px
2    = 0.5rem  = 8px
3    = 1rem    = 16px
4    = 1.5rem  = 24px
5    = 3rem    = 48px
```

### Used in Component
```
mb-2 → margin-bottom: 8px
mb-3 → margin-bottom: 16px
mb-4 → margin-bottom: 24px
py-5 → padding vert: 48px
g-3  → grid gap: 16px
gap-2 → flex gap: 8px
```

---

## Font Sizing

Bootstrap default font scale:

```
h1 = 2.5rem (40px)
h2 = 2rem   (32px)
h3 = 1.75rem (28px)
h4 = 1.5rem (24px)
h5 = 1.25rem (20px)
h6 = 1rem   (16px)
p  = 1rem   (16px)
```

### Used in Component
```
.page-title → 2rem (32px)
h4          → 1.5rem (24px)
h5          → 1.25rem (20px)
Default p   → 1rem (16px)
```

---

## Border Radius

Bootstrap border-radius scale:

```
.rounded-0   = 0
.rounded-1   = 0.25rem (4px)
.rounded-2   = 0.375rem (6px)
.rounded-3   = 0.5rem (8px)
.rounded-4   = 0.75rem (12px)
.rounded-5   = 1rem (16px)
.rounded     = 0.375rem (6px) - default
```

### Used in Component
```
Border-radius: 0.375rem (6px) applied via Bootstrap
Cards have default rounded corners
Buttons have default rounded corners
Badges have default rounded corners
```

---

## Shadows

Bootstrap shadow scale:

```
.shadow-none = none
.shadow-sm   = 0 0.125rem 0.25rem rgba(0,0,0,0.075)
.shadow      = 0 0.5rem 1rem rgba(0,0,0,0.15)
.shadow-lg   = 0 1rem 3rem rgba(0,0,0,0.175)
```

### Used in Component
```
.shadow-sm       → on .card (subtle shadow)
.shadow-sm       → on .ticket-card
Custom shadow    → on .ticket-card:hover
Box-shadow       → on .toast-container
```

---

## Animations

### Fade In Animation
```css
@keyframes fadein {
	from {
		opacity: 0;
		transform: translateY(10px);
	}
	to {
		opacity: 1;
		transform: translateY(0);
	}
}

.toast-container {
	animation: fadein 0.3s ease-in-out;
}
```

### Card Hover Animation
```css
.ticket-card {
	transition: all 0.3s ease;
}

.ticket-card:hover {
	transform: translateY(-4px);
	box-shadow: 0 8px 16px rgba(0, 0, 0, 0.1) !important;
}
```

---

## Form Styling

### Input Focus State
```css
.form-control:focus, .form-select:focus {
	border-color: #1b6ec2;
	box-shadow: 0 0 0 0.2rem rgba(27, 110, 194, 0.25);
}
```

### Textarea Customization
```css
textarea.form-control {
	resize: vertical;
	min-height: 100px;
}
```

---

## Button States

### Primary Button
```css
.btn-primary {
	color: #fff;
	background-color: #1b6ec2;
	border-color: #1861ac;
}

.btn-primary:hover {
	background-color: #1563b6;
	box-shadow: 0 2px 8px rgba(27, 110, 194, 0.3);
}
```

### Danger Button
```css
.btn-danger:hover {
	background-color: #c82333;
	box-shadow: 0 2px 8px rgba(220, 53, 69, 0.3);
}
```

---

## Media Queries

### Mobile Optimization
```css
@media (max-width: 768px) {
	.page-title {
		font-size: 1.5rem;
	}

	.ticket-card {
		margin-bottom: 1rem;
	}

	.d-flex.gap-2 {
		flex-wrap: wrap;
	}

	.btn-sm {
		font-size: 0.8rem;
		padding: 0.4rem 0.6rem;
	}
}
```

---

## Utility Classes Reference

### Margin
```
m*   = margin all
mt*  = margin-top
mb*  = margin-bottom
ml*  = margin-left
mr*  = margin-right
mx*  = margin horizontal
my*  = margin vertical
```

### Padding
```
p*   = padding all
pt*  = padding-top
pb*  = padding-bottom
pl*  = padding-left
pr*  = padding-right
px*  = padding horizontal
py*  = padding vertical
```

### Scale (0-5, auto)
```
-0  = 0rem (0px)
-1  = 0.25rem (4px)
-2  = 0.5rem (8px)
-3  = 1rem (16px)
-4  = 1.5rem (24px)
-5  = 3rem (48px)
-auto = auto
```

---

## Complete Color Palette

### Bootstrap Colors
```
Primary:    #0d6efd (blue)
Secondary:  #6c757d (gray)
Success:    #198754 (green)
Danger:     #dc3545 (red)
Warning:    #ffc107 (yellow)
Info:       #0dcaf0 (cyan)
Light:      #f8f9fa (light gray)
Dark:       #212529 (dark gray)
```

### Custom Colors
```
Page Title: #333 (dark gray)
Muted Text: #666 (medium gray)
Border:     #e0e0e0 (light gray)
Focus:      #1b6ec2 (primary blue)
```

---

## Summary

The component uses:
- ✅ 50+ Bootstrap utility classes
- ✅ Bootstrap 5 components (cards, badges, forms, buttons, pagination, alerts)
- ✅ Custom CSS for cards and page styling
- ✅ Responsive design with mobile-first approach
- ✅ Accessibility best practices
- ✅ Professional color scheme
- ✅ Smooth animations and transitions

All classes are standard Bootstrap 5 except for custom `.page-header`, `.page-title`, and `.ticket-card` classes defined in `app.css`.
