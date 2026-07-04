# Quick Reference Guide

## What Changed?

### Layout
| Before | After |
|--------|-------|
| Card-based grid | List view with rows |
| Form at top | Modal popup |
| Horizontal filters | Vertical sidebar |
| Action buttons inline | Actions at end of row |

### Visual Changes
```
BEFORE:                          AFTER:
┌────────────────┬──────────┐    ┌──────────┬─────────────────────┐
│ Create Form    │Filters   │    │Filters   │ Heading [➕Create]   │
│ (2 col layout) │(below)   │    │(sidebar) │ ─────────────────── │
├────────────────┼──────────┤    │          │ List Row 1 ... [✏️] │
│ Card 1         │          │    │          │ List Row 2 ... [✏️] │
│ Card 2         │          │    │          │ List Row 3 ... [✏️] │
│ Card 3         │          │    │          │ ─────────────────── │
│ Pagination     │          │    │          │ Pagination          │
└────────────────┴──────────┘    └──────────┴─────────────────────┘
```

---

## Key Features

### 1. Sidebar Filter (LEFT)
✅ Search box (real-time input)
✅ Status dropdown
✅ Priority dropdown  
✅ Search button
✅ Clear button
✅ Refresh button
✅ Results counter
✅ Sticky position

### 2. Main Content Area (RIGHT)
✅ Page title "Tickets"
✅ "➕ Create New Ticket" button (top right, green)
✅ List of tickets with columns:
   - Title
   - Status (colored badge)
   - Priority (colored badge)
   - Description (preview)
   - Actions (Edit/Delete buttons)
✅ Pagination controls

### 3. Modal Popups
✅ Opens when "Create" or "Edit" clicked
✅ Centered on screen
✅ Semi-transparent backdrop
✅ Close button (×)
✅ Form fields:
   - Title (required)
   - Description (required)
   - Status dropdown
   - Priority dropdown
✅ Cancel & Save buttons

### 4. Responsive Design
✅ Desktop: Sidebar left + List right
✅ Tablet: Same layout, list columns adjusted
✅ Mobile: Sidebar below list, full width, stacked rows

---

## How to Use

### Create New Ticket
1. Click green "➕ Create New Ticket" button (top right)
2. Modal popup appears
3. Fill in Title & Description
4. Select Status & Priority
5. Click "Create Ticket"
6. Modal closes, list updates

### Edit Ticket
1. Click "✏️" icon at end of ticket row
2. Modal popup with ticket data loaded
3. Make changes
4. Click "Update Ticket"
5. Modal closes, list updates

### Delete Ticket
1. Click "🗑️" icon at end of ticket row
2. Confirmation dialog appears
3. Click "OK" to confirm
4. Ticket deleted, list updates
5. Success notification shown

### Search & Filter
1. Use left sidebar to filter:
   - Type in Search box
   - Select Status
   - Select Priority
2. Click "Search" button
3. List updates with results
4. Click "Clear" to reset all

---

## Colors & Badges

### Status Badges
- 🔴 **Open** = Red badge
- 🟡 **In Progress** = Yellow badge
- 🟢 **Closed** = Green badge

### Priority Badges
- 💙 **Low** = Blue badge
- 🟡 **Medium** = Yellow badge
- ❤️ **High** = Red badge

### Buttons
- Green: "Create New Ticket"
- Blue: Primary actions (Search)
- Gray: Secondary actions (Clear)
- No fill: Edit/Delete (outline only)

---

## File Locations

```
Modified Files:
📄 Tickets.razor          → List view + modal logic
📄 app.css               → New layout styling

Documentation:
📄 UI_REDESIGN.md        → Full redesign details
📄 LAYOUT_GUIDE.md       → Visual layout guide
📄 QUICK_REFERENCE.md    → This file
```

---

## CSS Classes Reference

### Layout
- `.tickets-container` - Main page container
- `.sidebar-left` - Left filter sidebar
- `.main-content` - Right main content area
- `.sticky-filter` - Sticky filter section

### List Display
- `.list-header` - Column headers
- `.list-item` - Individual ticket row
- `.col-ticket-title` - Title column
- `.col-ticket-status` - Status column
- `.col-ticket-priority` - Priority column
- `.col-ticket-description` - Description column
- `.col-ticket-actions` - Actions column

### Modal
- `.modal` - Modal container
- `.modal.show` - Visible modal
- `.modal-dialog-centered` - Centered positioning
- `.modal-content` - Modal box
- `.modal-header` - Top section with title
- `.modal-body` - Form content area

### Notifications
- `.toast-container` - Notification box
- `.toast-container.success` - Green success notification
- `.toast-container.error` - Red error notification

---

## Responsive Breakpoints

### Desktop (> 1200px)
- Sidebar: 25% width (sticky left)
- Main: 75% width
- All columns visible
- Full descriptions shown

### Tablet (768px - 1199px)
- Sidebar: 25% width
- Main: 75% width
- Description column hidden
- Smaller text sizes

### Mobile (< 768px)
- Full width layout
- Stacked rows (vertical)
- Sidebar below main content
- All columns visible but stacked

---

## Keyboard Navigation

| Key | Action |
|-----|--------|
| Tab | Navigate between form fields |
| Enter | Submit form |
| Esc | Close modal |
| Ctrl+Enter | Quick save (in modal) |

---

## Performance Tips

✅ Sidebar is sticky - doesn't reload
✅ Modal is lightweight - no page reload
✅ Pagination handled server-side
✅ Smooth CSS animations (60fps)
✅ No flickering or lag

---

## Browser Support

✅ Chrome/Edge (Latest)
✅ Firefox (Latest)
✅ Safari (Latest)
✅ Mobile Browsers (iOS Safari, Chrome Android)

---

## Common Tasks

### Change Create Button Color
Edit `app.css`:
```css
.content-header .btn-success {
	background-color: #your-color;
}
```

### Adjust Sidebar Width
Edit `Tickets.razor`:
```html
<div class="col-12 col-md-3">  <!-- Change col-md-3 to col-md-4 -->
```
And update `.main-content` in CSS

### Hide Description in List
Edit `app.css`:
```css
.col-ticket-description {
	display: none;
}
```

### Add More Columns
Edit `Tickets.razor` list-header and list-item sections

---

## Troubleshooting

| Issue | Solution |
|-------|----------|
| Modal not showing | Check `showModal` variable |
| Filters not working | Verify API endpoint |
| List not updating | Call `LoadTickets()` |
| Sidebar content scrolling | Check viewport height |
| Buttons not clickable | Check z-index on modal |

---

## Summary

The redesigned tickets page now features:
1. **Vertical Sidebar** - Filters on the left
2. **List View** - Clean row-based display
3. **Modal Forms** - Popup for create/edit
4. **Responsive** - Works on all devices
5. **Professional** - Modern, organized layout
6. **User-Friendly** - Intuitive interactions
7. **Performance** - Fast and smooth
8. **Accessible** - Clear navigation

All changes maintain compatibility with the existing API!
