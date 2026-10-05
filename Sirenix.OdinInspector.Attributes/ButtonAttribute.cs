using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x02000007 RID: 7
	[Token(Token = "0x2000007")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = false)]
	[Conditional("UNITY_EDITOR")]
	public class ButtonAttribute : ShowInInspectorAttribute
	{
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000C RID: 12 RVA: 0x00002058 File Offset: 0x00000258
		// (set) Token: 0x0600000D RID: 13 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000002")]
		public int ButtonHeight
		{
			[Token(Token = "0x600000C")]
			[Address(RVA = "0x4EF610", Offset = "0x4EE210", VA = "0x1804EF610")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600000D")]
			[Address(RVA = "0x4E17AC0", Offset = "0x4E166C0", VA = "0x184E17AC0")]
			set
			{
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000E RID: 14 RVA: 0x00002070 File Offset: 0x00000270
		// (set) Token: 0x0600000F RID: 15 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000003")]
		public IconAlignment IconAlignment
		{
			[Token(Token = "0x600000E")]
			[Address(RVA = "0xC91700", Offset = "0xC90300", VA = "0x180C91700")]
			get
			{
				return IconAlignment.LeftOfText;
			}
			[Token(Token = "0x600000F")]
			[Address(RVA = "0x4E17AF0", Offset = "0x4E166F0", VA = "0x184E17AF0")]
			set
			{
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000010 RID: 16 RVA: 0x00002088 File Offset: 0x00000288
		// (set) Token: 0x06000011 RID: 17 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000004")]
		public float ButtonAlignment
		{
			[Token(Token = "0x6000010")]
			[Address(RVA = "0x16923F0", Offset = "0x1690FF0", VA = "0x1816923F0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000011")]
			[Address(RVA = "0x4E17AB0", Offset = "0x4E166B0", VA = "0x184E17AB0")]
			set
			{
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000012 RID: 18 RVA: 0x000020A0 File Offset: 0x000002A0
		// (set) Token: 0x06000013 RID: 19 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000005")]
		public bool Stretch
		{
			[Token(Token = "0x6000012")]
			[Address(RVA = "0x34BF5E0", Offset = "0x34BE1E0", VA = "0x1834BF5E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000013")]
			[Address(RVA = "0x4E17B00", Offset = "0x4E16700", VA = "0x184E17B00")]
			set
			{
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000015 RID: 21 RVA: 0x000020B8 File Offset: 0x000002B8
		// (set) Token: 0x06000014 RID: 20 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000006")]
		public bool DrawResult
		{
			[Token(Token = "0x6000015")]
			[Address(RVA = "0x4EF600", Offset = "0x4EE200", VA = "0x1804EF600")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000014")]
			[Address(RVA = "0x4E17AD0", Offset = "0x4E166D0", VA = "0x184E17AD0")]
			set
			{
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000016 RID: 22 RVA: 0x000020D0 File Offset: 0x000002D0
		[Token(Token = "0x17000007")]
		public bool DrawResultIsSet
		{
			[Token(Token = "0x6000016")]
			[Address(RVA = "0x106F290", Offset = "0x106DE90", VA = "0x18106F290")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000017 RID: 23 RVA: 0x000020E8 File Offset: 0x000002E8
		// (set) Token: 0x06000018 RID: 24 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000008")]
		public bool HasDefinedButtonHeight
		{
			[Token(Token = "0x6000017")]
			[Address(RVA = "0x4EA840", Offset = "0x4E9440", VA = "0x1804EA840")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000018")]
			[Address(RVA = "0x4EA980", Offset = "0x4E9580", VA = "0x1804EA980")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000019 RID: 25 RVA: 0x00002100 File Offset: 0x00000300
		[Token(Token = "0x17000009")]
		public bool HasDefinedIcon
		{
			[Token(Token = "0x6000019")]
			[Address(RVA = "0x1FF92B0", Offset = "0x1FF7EB0", VA = "0x181FF92B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600001A RID: 26 RVA: 0x00002118 File Offset: 0x00000318
		// (set) Token: 0x0600001B RID: 27 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700000A")]
		public bool HasDefinedButtonIconAlignment
		{
			[Token(Token = "0x600001A")]
			[Address(RVA = "0x4EA870", Offset = "0x4E9470", VA = "0x1804EA870")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600001B")]
			[Address(RVA = "0x4EAC00", Offset = "0x4E9800", VA = "0x1804EAC00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600001C RID: 28 RVA: 0x00002130 File Offset: 0x00000330
		// (set) Token: 0x0600001D RID: 29 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700000B")]
		public bool HasDefinedButtonAlignment
		{
			[Token(Token = "0x600001C")]
			[Address(RVA = "0x3581DB0", Offset = "0x35809B0", VA = "0x183581DB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600001D")]
			[Address(RVA = "0x3581DE0", Offset = "0x35809E0", VA = "0x183581DE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600001E RID: 30 RVA: 0x00002148 File Offset: 0x00000348
		// (set) Token: 0x0600001F RID: 31 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700000C")]
		public bool HasDefinedStretch
		{
			[Token(Token = "0x600001E")]
			[Address(RVA = "0x4E17AA0", Offset = "0x4E166A0", VA = "0x184E17AA0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600001F")]
			[Address(RVA = "0x4E17AE0", Offset = "0x4E166E0", VA = "0x184E17AE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x4E17940", Offset = "0x4E16540", VA = "0x184E17940")]
		public ButtonAttribute()
		{
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x4E17860", Offset = "0x4E16460", VA = "0x184E17860")]
		public ButtonAttribute(ButtonSizes size)
		{
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x4E179C0", Offset = "0x4E165C0", VA = "0x184E179C0")]
		public ButtonAttribute(int buttonSize)
		{
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x4E17790", Offset = "0x4E16390", VA = "0x184E17790")]
		public ButtonAttribute(string name)
		{
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x4E17740", Offset = "0x4E16340", VA = "0x184E17740")]
		public ButtonAttribute(string name, ButtonSizes buttonSize)
		{
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x4E17740", Offset = "0x4E16340", VA = "0x184E17740")]
		public ButtonAttribute(string name, int buttonSize)
		{
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x4E17900", Offset = "0x4E16500", VA = "0x184E17900")]
		public ButtonAttribute(ButtonStyle parameterBtnStyle)
		{
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x4E17970", Offset = "0x4E16570", VA = "0x184E17970")]
		public ButtonAttribute(int buttonSize, ButtonStyle parameterBtnStyle)
		{
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x4E17970", Offset = "0x4E16570", VA = "0x184E17970")]
		public ButtonAttribute(ButtonSizes size, ButtonStyle parameterBtnStyle)
		{
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x4E17810", Offset = "0x4E16410", VA = "0x184E17810")]
		public ButtonAttribute(string name, ButtonStyle parameterBtnStyle)
		{
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x4E178A0", Offset = "0x4E164A0", VA = "0x184E178A0")]
		public ButtonAttribute(string name, ButtonSizes buttonSize, ButtonStyle parameterBtnStyle)
		{
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x4E178A0", Offset = "0x4E164A0", VA = "0x184E178A0")]
		public ButtonAttribute(string name, int buttonSize, ButtonStyle parameterBtnStyle)
		{
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x4E17A50", Offset = "0x4E16650", VA = "0x184E17A50")]
		public ButtonAttribute(SdfIconType icon, IconAlignment iconAlignment)
		{
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x4E177D0", Offset = "0x4E163D0", VA = "0x184E177D0")]
		public ButtonAttribute(SdfIconType icon)
		{
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x4E17A00", Offset = "0x4E16600", VA = "0x184E17A00")]
		public ButtonAttribute(SdfIconType icon, string name)
		{
		}

		// Token: 0x04000017 RID: 23
		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x10")]
		public string Name;

		// Token: 0x04000018 RID: 24
		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x18")]
		public ButtonStyle Style;

		// Token: 0x04000019 RID: 25
		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x1C")]
		public bool Expanded;

		// Token: 0x0400001A RID: 26
		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x1D")]
		public bool DisplayParameters;

		// Token: 0x0400001B RID: 27
		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x1E")]
		public bool DirtyOnClick;

		// Token: 0x0400001C RID: 28
		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x20")]
		public SdfIconType Icon;

		// Token: 0x04000021 RID: 33
		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0x28")]
		private int buttonHeight;

		// Token: 0x04000022 RID: 34
		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0x2C")]
		private bool drawResult;

		// Token: 0x04000023 RID: 35
		[Token(Token = "0x4000023")]
		[FieldOffset(Offset = "0x2D")]
		private bool drawResultIsSet;

		// Token: 0x04000024 RID: 36
		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0x2E")]
		private bool stretch;

		// Token: 0x04000025 RID: 37
		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0x30")]
		private IconAlignment buttonIconAlignment;

		// Token: 0x04000026 RID: 38
		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0x34")]
		private float buttonAlignment;
	}
}
