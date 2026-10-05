using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Collections;
using UnityEngine.TextCore.Text;

namespace UnityEngine.UIElements
{
	// Token: 0x02000263 RID: 611
	[Token(Token = "0x2000263")]
	internal struct TextNativeHandle : ITextHandle
	{
		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x0600114D RID: 4429 RVA: 0x000096A8 File Offset: 0x000078A8
		// (set) Token: 0x0600114E RID: 4430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000460")]
		public Vector2 MeasuredSizes
		{
			[Token(Token = "0x600114D")]
			[Address(RVA = "0x925550", Offset = "0x924150", VA = "0x180925550", Slot = "13")]
			[CompilerGenerated]
			readonly get
			{
				return default(Vector2);
			}
			[Token(Token = "0x600114E")]
			[Address(RVA = "0x925680", Offset = "0x924280", VA = "0x180925680", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x0600114F RID: 4431 RVA: 0x000096C0 File Offset: 0x000078C0
		// (set) Token: 0x06001150 RID: 4432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000461")]
		public Vector2 RoundedSizes
		{
			[Token(Token = "0x600114F")]
			[Address(RVA = "0x15795A0", Offset = "0x15781A0", VA = "0x1815795A0", Slot = "14")]
			[CompilerGenerated]
			readonly get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6001150")]
			[Address(RVA = "0x33E8CB0", Offset = "0x33E78B0", VA = "0x1833E8CB0", Slot = "12")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001151 RID: 4433 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6001151")]
		[Address(RVA = "0x5B28100", Offset = "0x5B26D00", VA = "0x185B28100")]
		public static ITextHandle New()
		{
			return null;
		}

		// Token: 0x06001152 RID: 4434 RVA: 0x000096D8 File Offset: 0x000078D8
		[Token(Token = "0x6001152")]
		[Address(RVA = "0x3E67470", Offset = "0x3E66070", VA = "0x183E67470", Slot = "9")]
		public bool IsLegacy()
		{
			return default(bool);
		}

		// Token: 0x06001153 RID: 4435 RVA: 0x000096F0 File Offset: 0x000078F0
		[Token(Token = "0x6001153")]
		[Address(RVA = "0x5B27D70", Offset = "0x5B26970", VA = "0x185B27D70", Slot = "7")]
		public float GetLineHeight(int characterIndex, MeshGenerationContextUtils.TextParams textParams, float textScaling, float pixelPerPoint)
		{
			return 0f;
		}

		// Token: 0x06001154 RID: 4436 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6001154")]
		[Address(RVA = "0x5B28160", Offset = "0x5B26D60", VA = "0x185B28160", Slot = "8")]
		public TextInfo Update(MeshGenerationContextUtils.TextParams parms, float pixelsPerPoint)
		{
			return null;
		}

		// Token: 0x06001155 RID: 4437 RVA: 0x00009708 File Offset: 0x00007908
		[Token(Token = "0x6001155")]
		[Address(RVA = "0x5B27E10", Offset = "0x5B26A10", VA = "0x185B27E10")]
		public NativeArray<TextVertex> GetVertices(MeshGenerationContextUtils.TextParams parms, float scaling)
		{
			return default(NativeArray<TextVertex>);
		}

		// Token: 0x06001156 RID: 4438 RVA: 0x00009720 File Offset: 0x00007920
		[Token(Token = "0x6001156")]
		[Address(RVA = "0x5B27CE0", Offset = "0x5B268E0", VA = "0x185B27CE0", Slot = "4")]
		public Vector2 GetCursorPosition(CursorPositionStylePainterParameters parms, float scaling)
		{
			return default(Vector2);
		}

		// Token: 0x06001157 RID: 4439 RVA: 0x00009738 File Offset: 0x00007938
		[Token(Token = "0x6001157")]
		[Address(RVA = "0x5B27BF0", Offset = "0x5B267F0", VA = "0x185B27BF0", Slot = "5")]
		public float ComputeTextWidth(MeshGenerationContextUtils.TextParams parms, float scaling)
		{
			return 0f;
		}

		// Token: 0x06001158 RID: 4440 RVA: 0x00009750 File Offset: 0x00007950
		[Token(Token = "0x6001158")]
		[Address(RVA = "0x5B27B30", Offset = "0x5B26730", VA = "0x185B27B30", Slot = "6")]
		public float ComputeTextHeight(MeshGenerationContextUtils.TextParams parms, float scaling)
		{
			return 0f;
		}

		// Token: 0x06001159 RID: 4441 RVA: 0x00009768 File Offset: 0x00007968
		[Token(Token = "0x6001159")]
		[Address(RVA = "0x591F3A0", Offset = "0x591DFA0", VA = "0x18591F3A0", Slot = "10")]
		public bool IsElided()
		{
			return default(bool);
		}

		// Token: 0x04000907 RID: 2311
		[Token(Token = "0x4000907")]
		[FieldOffset(Offset = "0x10")]
		internal NativeArray<TextVertex> textVertices;

		// Token: 0x04000908 RID: 2312
		[Token(Token = "0x4000908")]
		[FieldOffset(Offset = "0x20")]
		private int m_PreviousTextParamsHash;
	}
}
