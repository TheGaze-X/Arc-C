using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x0200003F RID: 63
	[Token(Token = "0x200003F")]
	[Conditional("UNITY_EDITOR")]
	[AttributeUsage(AttributeTargets.All)]
	public class InlineEditorAttribute : Attribute
	{
		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x00002280 File Offset: 0x00000480
		// (set) Token: 0x060000A9 RID: 169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000021")]
		public bool Expanded
		{
			[Token(Token = "0x60000A8")]
			[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000A9")]
			[Address(RVA = "0x4E18BD0", Offset = "0x4E177D0", VA = "0x184E18BD0")]
			set
			{
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000AA RID: 170 RVA: 0x00002298 File Offset: 0x00000498
		// (set) Token: 0x060000AB RID: 171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000022")]
		public bool ExpandedHasValue
		{
			[Token(Token = "0x60000AA")]
			[Address(RVA = "0xAE5EF0", Offset = "0xAE4AF0", VA = "0x180AE5EF0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000AB")]
			[Address(RVA = "0x17F30F0", Offset = "0x17F1CF0", VA = "0x1817F30F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x4E18A50", Offset = "0x4E17650", VA = "0x184E18A50")]
		public InlineEditorAttribute(InlineEditorModes inlineEditorMode = InlineEditorModes.GUIOnly, InlineEditorObjectFieldModes objectFieldMode = InlineEditorObjectFieldModes.Boxed)
		{
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x4E18B80", Offset = "0x4E17780", VA = "0x184E18B80")]
		public InlineEditorAttribute(InlineEditorObjectFieldModes objectFieldMode)
		{
		}

		// Token: 0x04000082 RID: 130
		[Token(Token = "0x4000082")]
		[FieldOffset(Offset = "0x10")]
		private bool expanded;

		// Token: 0x04000083 RID: 131
		[Token(Token = "0x4000083")]
		[FieldOffset(Offset = "0x11")]
		public bool DrawHeader;

		// Token: 0x04000084 RID: 132
		[Token(Token = "0x4000084")]
		[FieldOffset(Offset = "0x12")]
		public bool DrawGUI;

		// Token: 0x04000085 RID: 133
		[Token(Token = "0x4000085")]
		[FieldOffset(Offset = "0x13")]
		public bool DrawPreview;

		// Token: 0x04000086 RID: 134
		[Token(Token = "0x4000086")]
		[FieldOffset(Offset = "0x14")]
		public float MaxHeight;

		// Token: 0x04000087 RID: 135
		[Token(Token = "0x4000087")]
		[FieldOffset(Offset = "0x18")]
		public float PreviewWidth;

		// Token: 0x04000088 RID: 136
		[Token(Token = "0x4000088")]
		[FieldOffset(Offset = "0x1C")]
		public float PreviewHeight;

		// Token: 0x04000089 RID: 137
		[Token(Token = "0x4000089")]
		[FieldOffset(Offset = "0x20")]
		public bool IncrementInlineEditorDrawerDepth;

		// Token: 0x0400008A RID: 138
		[Token(Token = "0x400008A")]
		[FieldOffset(Offset = "0x24")]
		public InlineEditorObjectFieldModes ObjectFieldMode;

		// Token: 0x0400008B RID: 139
		[Token(Token = "0x400008B")]
		[FieldOffset(Offset = "0x28")]
		public bool DisableGUIForVCSLockedAssets;

		// Token: 0x0400008C RID: 140
		[Token(Token = "0x400008C")]
		[FieldOffset(Offset = "0x2C")]
		public PreviewAlignment PreviewAlignment;
	}
}
