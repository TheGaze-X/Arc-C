using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.TextCore.Text;

namespace UnityEngine.UIElements
{
	// Token: 0x02000262 RID: 610
	[Token(Token = "0x2000262")]
	internal struct TextCoreHandle : ITextHandle
	{
		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x0600113A RID: 4410 RVA: 0x000095B8 File Offset: 0x000077B8
		// (set) Token: 0x0600113B RID: 4411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700045C")]
		public Vector2 MeasuredSizes
		{
			[Token(Token = "0x600113A")]
			[Address(RVA = "0x925550", Offset = "0x924150", VA = "0x180925550", Slot = "13")]
			[CompilerGenerated]
			readonly get
			{
				return default(Vector2);
			}
			[Token(Token = "0x600113B")]
			[Address(RVA = "0x925680", Offset = "0x924280", VA = "0x180925680", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x0600113C RID: 4412 RVA: 0x000095D0 File Offset: 0x000077D0
		// (set) Token: 0x0600113D RID: 4413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700045D")]
		public Vector2 RoundedSizes
		{
			[Token(Token = "0x600113C")]
			[Address(RVA = "0x15795A0", Offset = "0x15781A0", VA = "0x1815795A0", Slot = "14")]
			[CompilerGenerated]
			readonly get
			{
				return default(Vector2);
			}
			[Token(Token = "0x600113D")]
			[Address(RVA = "0x33E8CB0", Offset = "0x33E78B0", VA = "0x1833E8CB0", Slot = "12")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600113E RID: 4414 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x600113E")]
		[Address(RVA = "0x5B26BC0", Offset = "0x5B257C0", VA = "0x185B26BC0")]
		public static ITextHandle New()
		{
			return null;
		}

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x0600113F RID: 4415 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x1700045E")]
		internal TextInfo textInfoMesh
		{
			[Token(Token = "0x600113F")]
			[Address(RVA = "0x5B27AB0", Offset = "0x5B266B0", VA = "0x185B27AB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x06001140 RID: 4416 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x1700045F")]
		internal static TextInfo textInfoLayout
		{
			[Token(Token = "0x6001140")]
			[Address(RVA = "0x5B279B0", Offset = "0x5B265B0", VA = "0x185B279B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001141 RID: 4417 RVA: 0x000095E8 File Offset: 0x000077E8
		[Token(Token = "0x6001141")]
		[Address(RVA = "0x591F3A0", Offset = "0x591DFA0", VA = "0x18591F3A0", Slot = "9")]
		public bool IsLegacy()
		{
			return default(bool);
		}

		// Token: 0x06001142 RID: 4418 RVA: 0x00009600 File Offset: 0x00007800
		[Token(Token = "0x6001142")]
		[Address(RVA = "0x5B26B20", Offset = "0x5B25720", VA = "0x185B26B20")]
		public bool IsDirty(MeshGenerationContextUtils.TextParams parms)
		{
			return default(bool);
		}

		// Token: 0x06001143 RID: 4419 RVA: 0x00009618 File Offset: 0x00007818
		[Token(Token = "0x6001143")]
		[Address(RVA = "0x5B268F0", Offset = "0x5B254F0", VA = "0x185B268F0", Slot = "4")]
		public Vector2 GetCursorPosition(CursorPositionStylePainterParameters parms, float scaling)
		{
			return default(Vector2);
		}

		// Token: 0x06001144 RID: 4420 RVA: 0x00009630 File Offset: 0x00007830
		[Token(Token = "0x6001144")]
		[Address(RVA = "0x5B26810", Offset = "0x5B25410", VA = "0x185B26810", Slot = "5")]
		public float ComputeTextWidth(MeshGenerationContextUtils.TextParams parms, float scaling)
		{
			return 0f;
		}

		// Token: 0x06001145 RID: 4421 RVA: 0x00009648 File Offset: 0x00007848
		[Token(Token = "0x6001145")]
		[Address(RVA = "0x5B26730", Offset = "0x5B25330", VA = "0x185B26730", Slot = "6")]
		public float ComputeTextHeight(MeshGenerationContextUtils.TextParams parms, float scaling)
		{
			return 0f;
		}

		// Token: 0x06001146 RID: 4422 RVA: 0x00009660 File Offset: 0x00007860
		[Token(Token = "0x6001146")]
		[Address(RVA = "0x5B26990", Offset = "0x5B25590", VA = "0x185B26990", Slot = "7")]
		public float GetLineHeight(int characterIndex, MeshGenerationContextUtils.TextParams textParams, float textScaling, float pixelPerPoint)
		{
			return 0f;
		}

		// Token: 0x06001147 RID: 4423 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6001147")]
		[Address(RVA = "0x5B27500", Offset = "0x5B26100", VA = "0x185B27500", Slot = "8")]
		public TextInfo Update(MeshGenerationContextUtils.TextParams parms, float pixelsPerPoint)
		{
			return null;
		}

		// Token: 0x06001148 RID: 4424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001148")]
		[Address(RVA = "0x5B271F0", Offset = "0x5B25DF0", VA = "0x185B271F0")]
		private void UpdatePreferredValues(MeshGenerationContextUtils.TextParams parms)
		{
		}

		// Token: 0x06001149 RID: 4425 RVA: 0x00009678 File Offset: 0x00007878
		[Token(Token = "0x6001149")]
		[Address(RVA = "0x5B26AB0", Offset = "0x5B256B0", VA = "0x185B26AB0")]
		private static TextOverflowMode GetTextOverflowMode(MeshGenerationContextUtils.TextParams textParams)
		{
			return TextOverflowMode.Overflow;
		}

		// Token: 0x0600114A RID: 4426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600114A")]
		[Address(RVA = "0x5B26C90", Offset = "0x5B25890", VA = "0x185B26C90")]
		private static void UpdateGenerationSettingsCommon(MeshGenerationContextUtils.TextParams painterParams, TextGenerationSettings settings)
		{
		}

		// Token: 0x0600114B RID: 4427 RVA: 0x00009690 File Offset: 0x00007890
		[Token(Token = "0x600114B")]
		[Address(RVA = "0x5B26B60", Offset = "0x5B25760", VA = "0x185B26B60", Slot = "10")]
		public bool IsElided()
		{
			return default(bool);
		}

		// Token: 0x040008FE RID: 2302
		[Token(Token = "0x40008FE")]
		[FieldOffset(Offset = "0x10")]
		private Vector2 m_PreferredSize;

		// Token: 0x040008FF RID: 2303
		[Token(Token = "0x40008FF")]
		[FieldOffset(Offset = "0x18")]
		private int m_PreviousGenerationSettingsHash;

		// Token: 0x04000900 RID: 2304
		[Token(Token = "0x4000900")]
		[FieldOffset(Offset = "0x20")]
		private TextGenerationSettings m_CurrentGenerationSettings;

		// Token: 0x04000901 RID: 2305
		[Token(Token = "0x4000901")]
		[FieldOffset(Offset = "0x0")]
		private static TextGenerationSettings s_LayoutSettings;

		// Token: 0x04000902 RID: 2306
		[Token(Token = "0x4000902")]
		[FieldOffset(Offset = "0x28")]
		private TextInfo m_TextInfoMesh;

		// Token: 0x04000903 RID: 2307
		[Token(Token = "0x4000903")]
		[FieldOffset(Offset = "0x8")]
		private static TextInfo s_TextInfoLayout;

		// Token: 0x04000904 RID: 2308
		[Token(Token = "0x4000904")]
		[FieldOffset(Offset = "0x30")]
		private bool isDirty;
	}
}
