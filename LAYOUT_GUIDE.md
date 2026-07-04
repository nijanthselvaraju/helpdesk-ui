# UI Layout Visual Guide

## Desktop View (> 991px)

```
┌────────────────────────────────────────────────────────────────┐
│                                                                │
│  ┌──────────────────┬──────────────────────────────────────┐  │
│  │                  │  Tickets        [➕ Create New Ticket] │  │
│  │  🔍 FILTERS      ├──────────────────────────────────────┤  │
│  │ ──────────────── │ Ticket #1                            │  │
│  │                  │ • Title One Here 🔴 Low 50 chars... │  │
│  │ Search:          │   [✏️] [🗑️]                          │  │
│  │ [_Search_]       ├──────────────────────────────────────┤  │
│  │                  │ Ticket #2                            │  │
│  │ Status:          │ • Title Two Here 🟡 Medium 50 chars..│  │
│  │ [All ▼]          │   [✏️] [🗑️]                          │  │
│  │                  ├──────────────────────────────────────┤  │
│  │ Priority:        │ Ticket #3                            │  │
│  │ [All ▼]          │ • Title Three Here 🟢 High 50 chars..│  │
│  │                  │   [✏️] [🗑️]                          │  │
│  │ [Search]         ├──────────────────────────────────────┤  │
│  │ [Clear]          │ Page 1 of 2                          │  │
│  │ [Refresh]        │ [← Previous] [Next →]               │  │
│  │                  │                                      │  │
│  │ Results: 3       └──────────────────────────────────────┘  │
│  │ Total: 15        │                                       │  │
│  │                  │                                       │  │
│  └──────────────────┴───────────────────────────────────────┘  │
│                                                                │
└────────────────────────────────────────────────────────────────┘

Width: 25% Sidebar | 75% Main Content
```

---

## Tablet View (769px - 991px)

```
┌──────────────────────────────────────────────────┐
│                                                  │
│  Tickets        [➕ Create New Ticket]           │
│ ──────────────────────────────────────────────── │
│                                                  │
│ T1 🔴 Low   [✏️] [🗑️]                          │
│ ─────────────────────────────────────────────── │
│ T2 🟡 Medium [✏️] [🗑️]                          │
│ ─────────────────────────────────────────────── │
│ T3 🟢 High  [✏️] [🗑️]                          │
│                                                  │
│ Page 1 of 2                                     │
│ [← Previous] [Next →]                          │
│                                                  │
├──────────────────────────────────────────────── │
│                                                  │
│ 🔍 FILTERS                                      │
│ ─────────────────────────────────────────────── │
│ Search: [_Search_]                             │
│ Status: [All ▼]                                │
│ Priority: [All ▼]                              │
│ [Search] [Clear] [Refresh]                     │
│                                                  │
└──────────────────────────────────────────────────┘

Main Content: Full width
Sidebar: Below main content
```

---

## Mobile View (< 768px)

```
┌────────────────────────────┐
│                            │
│ Tickets   [➕ Create New]  │
│ ────────────────────────── │
│                            │
│ Title One                  │
│ Description...             │
│ 🔴 Low                    │
│ [✏️] [🗑️]                │
│ ────────────────────────── │
│ Title Two                  │
│ Description...             │
│ 🟡 Medium                 │
│ [✏️] [🗑️]                │
│ ────────────────────────── │
│ Title Three                │
│ Description...             │
│ 🟢 High                   │
│ [✏️] [🗑️]                │
│ ────────────────────────── │
│ Page 1 of 2                │
│ [← Previous] [Next →]     │
│                            │
├────────────────────────────┤
│ 🔍 FILTERS                │
│ ────────────────────────── │
│ Search: [_Search_]        │
│ Status: [All ▼]           │
│ Priority: [All ▼]         │
│ [Search] [Clear] [Refresh]│
│                            │
└────────────────────────────┘

Vertical stacked layout
Content: Full width
Sidebar: Below content
```

---

## Modal Popup

```
				  ┌─────────────────────────────────┐
				  │ ✏️ Edit Ticket      [×]        │
				  ├─────────────────────────────────┤
				  │                                 │
				  │ Title *                         │
				  │ [____________________________]  │
				  │                                 │
				  │ Description *                   │
				  │ [____________________________]  │
				  │ [____________________________]  │
				  │ [____________________________]  │
				  │                                 │
				  │ Status           Priority       │
				  │ [Open ▼]         [Low ▼]       │
				  │                                 │
				  │ [Cancel] [Update Ticket]       │
				  │                                 │
				  └─────────────────────────────────┘

Center on screen with semi-transparent backdrop
```

---

## List Item Detail

```
DESKTOP FORMAT:
┌───────────────────────────────────────────────────────────────┐
│ Title One Here      │ 🔴 Open │ 💙 Low │ Full descri... │[✏️][🗑️]│
└───────────────────────────────────────────────────────────────┘

TABLET FORMAT:
┌─────────────────────────────────────────────────┐
│ Title One Here      │ 🔴 Open │ 💙 Low │[✏️][🗑️]│
└─────────────────────────────────────────────────┘
(Description hidden)

MOBILE FORMAT:
┌──────────────────────────┐
│ Title One Here           │
│ Full description text... │
│ 🔴 Open  💙 Low         │
│ [✏️] [🗑️]              │
└──────────────────────────┘
(Stacked vertically)
```

---

## Sidebar Filters

```
┌──────────────────────────┐
│ 🔍 FILTERS               │
├──────────────────────────┤
│                          │
│ Search                   │
│ [__________________]    │
│                          │
│ Status                   │
│ [All Status ▼]          │
│ • All Status             │
│ • Open                   │
│ • In Progress            │
│ • Closed                 │
│                          │
│ Priority                 │
│ [All Priority ▼]        │
│ • All Priority           │
│ • Low                    │
│ • Medium                 │
│ • High                   │
│                          │
│ [Search] [Clear]        │
│ [Refresh]               │
│                          │
│ ┌────────────────────┐  │
│ │ Results: 3         │  │
│ │ Total: 15          │  │
│ └────────────────────┘  │
│                          │
└──────────────────────────┘

Sticky (stays at top while scrolling)
Responsive height on mobile
```

---

## Color Scheme

### Status Indicators
```
🔴 Open         → Red (#dc3545)
🟡 In Progress  → Yellow (#ffc107)
🟢 Closed       → Green (#28a745)
```

### Priority Indicators
```
💙 Low          → Blue (#0dcaf0)
🟡 Medium       → Yellow (#ffc107)
❤️  High        → Red (#dc3545)
```

### UI Elements
```
Action Buttons  → Light Blue (outline)
Delete Buttons  → Light Red (outline)
Create Button   → Full Green (#28a745)
Primary Button  → Full Blue (#0d6efd)
```

---

## Animations

### Modal Entrance
```
1. Initial: Backdrop opacity 0, Modal scaled down
2. Transition: 300ms fade in + scale up
3. Final: Backdrop opacity 50%, Modal at full size
```

### Notification Toast
```
1. Initial: Position +20px down, opacity 0
2. Transition: 300ms slide up + fade in
3. Display: 3000ms visible
4. Exit: 300ms slide down + fade out
```

### Hover Effects
```
- List Item: Background change to light gray
- Button: Slight shadow/highlight
- Badge: Cursor pointer (all clickable)
```

---

## Responsive Grid Breakpoints

### Desktop (> 1200px)
```
Grid: 2fr 1fr 1fr 2fr 1.2fr
Layout: Side-by-side (sidebar left, content right)
Sidebar Width: 25%
```

### Large Tablet (992px - 1199px)
```
Grid: 2fr 1fr 1fr 2fr 1.2fr
Layout: Side-by-side
Sidebar Width: 25%
Description: Visible
```

### Small Tablet (769px - 991px)
```
Grid: 1.5fr 1fr 1fr 1.5fr 1fr
Layout: Side-by-side
Sidebar Width: 25%
Description: Hidden
```

### Mobile (< 768px)
```
Grid: 1fr (full width, stacked)
Layout: Stacked vertical
Sidebar Below: Full width
Description: Visible but stacked
```

---

## Icons & Symbols

```
Navigation & Action:
  ➕  Create new
  ✏️  Edit
  🗑️  Delete
  🔄  Refresh
  ↻   Clear

Status Indicators:
  🔴  Open / High Priority
  🟡  In Progress / Medium Priority
  🟢  Closed / Success
  💙  Low Priority / Info
  ❤️   High Priority / Danger

Other:
  📭  Empty state
  🔍  Search/Filter
  (×)  Close modal
```

---

## User Flow Diagram

```
START
  ↓
[View Tickets List]
  ├─→ Adjust Filters (Sidebar)
  │   └─→ Click Search
  │       └─→ List Updates
  │
  ├─→ Click [➕ Create]
  │   └─→ Modal Opens
  │       ├─→ Fill Form
  │       └─→ Click Submit
  │           └─→ Modal Closes → List Updates
  │
  ├─→ Click [✏️ Edit]
  │   └─→ Modal Opens (with data)
  │       ├─→ Edit Fields
  │       └─→ Click Update
  │           └─→ Modal Closes → List Updates
  │
  ├─→ Click [🗑️ Delete]
  │   └─→ Confirmation Dialog
  │       ├─→ Cancel → Back to List
  │       └─→ Confirm → List Updates
  │
  └─→ Click [Next/Prev]
	  └─→ Pagination Changes → List Updates

END
```

---

## Summary

✅ **List View**: Default display with gridded layout
✅ **Sidebar**: Vertical filters on the left (responsive)
✅ **Modal**: Popups for create and edit forms
✅ **Actions**: Edit & Delete at end of each row
✅ **Responsive**: Works on desktop, tablet, and mobile
✅ **Professional**: Clean, organized, modern design
✅ **Accessible**: Keyboard navigation and clear labels
✅ **Fast**: Smooth animations and transitions
