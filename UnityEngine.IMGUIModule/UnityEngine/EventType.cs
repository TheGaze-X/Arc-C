using System;
using System.ComponentModel;
using Il2CppDummyDll;

namespace UnityEngine
{
	// Token: 0x02000005 RID: 5
	[Token(Token = "0x2000005")]
	public enum EventType
	{
		// Token: 0x04000005 RID: 5
		[Token(Token = "0x4000005")]
		MouseDown,
		// Token: 0x04000006 RID: 6
		[Token(Token = "0x4000006")]
		MouseUp,
		// Token: 0x04000007 RID: 7
		[Token(Token = "0x4000007")]
		MouseMove,
		// Token: 0x04000008 RID: 8
		[Token(Token = "0x4000008")]
		MouseDrag,
		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		KeyDown,
		// Token: 0x0400000A RID: 10
		[Token(Token = "0x400000A")]
		KeyUp,
		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		ScrollWheel,
		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		Repaint,
		// Token: 0x0400000D RID: 13
		[Token(Token = "0x400000D")]
		Layout,
		// Token: 0x0400000E RID: 14
		[Token(Token = "0x400000E")]
		DragUpdated,
		// Token: 0x0400000F RID: 15
		[Token(Token = "0x400000F")]
		DragPerform,
		// Token: 0x04000010 RID: 16
		[Token(Token = "0x4000010")]
		DragExited = 15,
		// Token: 0x04000011 RID: 17
		[Token(Token = "0x4000011")]
		Ignore = 11,
		// Token: 0x04000012 RID: 18
		[Token(Token = "0x4000012")]
		Used,
		// Token: 0x04000013 RID: 19
		[Token(Token = "0x4000013")]
		ValidateCommand,
		// Token: 0x04000014 RID: 20
		[Token(Token = "0x4000014")]
		ExecuteCommand,
		// Token: 0x04000015 RID: 21
		[Token(Token = "0x4000015")]
		ContextClick = 16,
		// Token: 0x04000016 RID: 22
		[Token(Token = "0x4000016")]
		MouseEnterWindow = 20,
		// Token: 0x04000017 RID: 23
		[Token(Token = "0x4000017")]
		MouseLeaveWindow,
		// Token: 0x04000018 RID: 24
		[Token(Token = "0x4000018")]
		TouchDown = 30,
		// Token: 0x04000019 RID: 25
		[Token(Token = "0x4000019")]
		TouchUp,
		// Token: 0x0400001A RID: 26
		[Token(Token = "0x400001A")]
		TouchMove,
		// Token: 0x0400001B RID: 27
		[Token(Token = "0x400001B")]
		TouchEnter,
		// Token: 0x0400001C RID: 28
		[Token(Token = "0x400001C")]
		TouchLeave,
		// Token: 0x0400001D RID: 29
		[Token(Token = "0x400001D")]
		TouchStationary,
		// Token: 0x0400001E RID: 30
		[Token(Token = "0x400001E")]
		[Obsolete("Use MouseDown instead (UnityUpgradable) -> MouseDown", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		mouseDown = 0,
		// Token: 0x0400001F RID: 31
		[Token(Token = "0x400001F")]
		[Obsolete("Use MouseUp instead (UnityUpgradable) -> MouseUp", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		mouseUp,
		// Token: 0x04000020 RID: 32
		[Token(Token = "0x4000020")]
		[Obsolete("Use MouseMove instead (UnityUpgradable) -> MouseMove", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		mouseMove,
		// Token: 0x04000021 RID: 33
		[Token(Token = "0x4000021")]
		[Obsolete("Use MouseDrag instead (UnityUpgradable) -> MouseDrag", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		mouseDrag,
		// Token: 0x04000022 RID: 34
		[Token(Token = "0x4000022")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use KeyDown instead (UnityUpgradable) -> KeyDown", true)]
		keyDown,
		// Token: 0x04000023 RID: 35
		[Token(Token = "0x4000023")]
		[Obsolete("Use KeyUp instead (UnityUpgradable) -> KeyUp", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		keyUp,
		// Token: 0x04000024 RID: 36
		[Token(Token = "0x4000024")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use ScrollWheel instead (UnityUpgradable) -> ScrollWheel", true)]
		scrollWheel,
		// Token: 0x04000025 RID: 37
		[Token(Token = "0x4000025")]
		[Obsolete("Use Repaint instead (UnityUpgradable) -> Repaint", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		repaint,
		// Token: 0x04000026 RID: 38
		[Token(Token = "0x4000026")]
		[Obsolete("Use Layout instead (UnityUpgradable) -> Layout", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		layout,
		// Token: 0x04000027 RID: 39
		[Token(Token = "0x4000027")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use DragUpdated instead (UnityUpgradable) -> DragUpdated", true)]
		dragUpdated,
		// Token: 0x04000028 RID: 40
		[Token(Token = "0x4000028")]
		[Obsolete("Use DragPerform instead (UnityUpgradable) -> DragPerform", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		dragPerform,
		// Token: 0x04000029 RID: 41
		[Token(Token = "0x4000029")]
		[Obsolete("Use Ignore instead (UnityUpgradable) -> Ignore", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		ignore,
		// Token: 0x0400002A RID: 42
		[Token(Token = "0x400002A")]
		[Obsolete("Use Used instead (UnityUpgradable) -> Used", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		used
	}
}
