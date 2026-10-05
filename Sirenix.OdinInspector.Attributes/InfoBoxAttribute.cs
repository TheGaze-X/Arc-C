using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x0200003D RID: 61
	[Token(Token = "0x200003D")]
	[Conditional("UNITY_EDITOR")]
	[DontApplyToListElements]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
	public sealed class InfoBoxAttribute : Attribute
	{
		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600009D RID: 157 RVA: 0x00002250 File Offset: 0x00000450
		// (set) Token: 0x0600009E RID: 158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001E")]
		public SdfIconType Icon
		{
			[Token(Token = "0x600009D")]
			[Address(RVA = "0x926F80", Offset = "0x925B80", VA = "0x180926F80")]
			get
			{
				return SdfIconType.None;
			}
			[Token(Token = "0x600009E")]
			[Address(RVA = "0x4E189E0", Offset = "0x4E175E0", VA = "0x184E189E0")]
			set
			{
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600009F RID: 159 RVA: 0x00002268 File Offset: 0x00000468
		// (set) Token: 0x060000A0 RID: 160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001F")]
		public bool HasDefinedIcon
		{
			[Token(Token = "0x600009F")]
			[Address(RVA = "0x4FD4C0", Offset = "0x4FC0C0", VA = "0x1804FD4C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000A0")]
			[Address(RVA = "0x14D9990", Offset = "0x14D8590", VA = "0x1814D9990")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x4E188B0", Offset = "0x4E174B0", VA = "0x184E188B0")]
		public InfoBoxAttribute(string message, InfoMessageType infoMessageType = InfoMessageType.Info, [Optional] string visibleIfMemberName)
		{
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x4E18910", Offset = "0x4E17510", VA = "0x184E18910")]
		public InfoBoxAttribute(string message, string visibleIfMemberName)
		{
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x4E18970", Offset = "0x4E17570", VA = "0x184E18970")]
		public InfoBoxAttribute(string message, SdfIconType icon, [Optional] string visibleIfMemberName)
		{
		}

		// Token: 0x04000074 RID: 116
		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Message;

		// Token: 0x04000075 RID: 117
		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InfoMessageType InfoMessageType;

		// Token: 0x04000076 RID: 118
		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string VisibleIf;

		// Token: 0x04000077 RID: 119
		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool GUIAlwaysEnabled;

		// Token: 0x04000078 RID: 120
		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string IconColor;

		// Token: 0x0400007A RID: 122
		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private SdfIconType icon;
	}
}
