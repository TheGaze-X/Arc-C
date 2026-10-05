using System;
using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200004A RID: 74
	[Token(Token = "0x200004A")]
	[RequiredByNativeCode]
	public struct Keyframe
	{
		// Token: 0x06000082 RID: 130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000082")]
		[Address(RVA = "0x592C400", Offset = "0x592B000", VA = "0x18592C400")]
		public Keyframe(float time, float value)
		{
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000083")]
		[Address(RVA = "0x592C390", Offset = "0x592AF90", VA = "0x18592C390")]
		public Keyframe(float time, float value, float inTangent, float outTangent)
		{
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000084")]
		[Address(RVA = "0x592C3C0", Offset = "0x592AFC0", VA = "0x18592C3C0")]
		public Keyframe(float time, float value, float inTangent, float outTangent, float inWeight, float outWeight)
		{
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000085 RID: 133 RVA: 0x00002328 File Offset: 0x00000528
		// (set) Token: 0x06000086 RID: 134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700000D")]
		public float time
		{
			[Token(Token = "0x6000085")]
			[Address(RVA = "0x592C440", Offset = "0x592B040", VA = "0x18592C440")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000086")]
			[Address(RVA = "0x8772C0", Offset = "0x875EC0", VA = "0x1808772C0")]
			set
			{
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000087 RID: 135 RVA: 0x00002340 File Offset: 0x00000540
		// (set) Token: 0x06000088 RID: 136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700000E")]
		public float value
		{
			[Token(Token = "0x6000087")]
			[Address(RVA = "0x5916B50", Offset = "0x5915750", VA = "0x185916B50")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000088")]
			[Address(RVA = "0x8772B0", Offset = "0x875EB0", VA = "0x1808772B0")]
			set
			{
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000089 RID: 137 RVA: 0x00002358 File Offset: 0x00000558
		// (set) Token: 0x0600008A RID: 138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700000F")]
		public float inTangent
		{
			[Token(Token = "0x6000089")]
			[Address(RVA = "0x592C420", Offset = "0x592B020", VA = "0x18592C420")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600008A")]
			[Address(RVA = "0x5DE4E0", Offset = "0x5DD0E0", VA = "0x1805DE4E0")]
			set
			{
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600008B RID: 139 RVA: 0x00002370 File Offset: 0x00000570
		// (set) Token: 0x0600008C RID: 140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000010")]
		public float outTangent
		{
			[Token(Token = "0x600008B")]
			[Address(RVA = "0x5917F50", Offset = "0x5916B50", VA = "0x185917F50")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600008C")]
			[Address(RVA = "0x8772A0", Offset = "0x875EA0", VA = "0x1808772A0")]
			set
			{
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600008D RID: 141 RVA: 0x00002388 File Offset: 0x00000588
		// (set) Token: 0x0600008E RID: 142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000011")]
		public float inWeight
		{
			[Token(Token = "0x600008D")]
			[Address(RVA = "0x5917F70", Offset = "0x5916B70", VA = "0x185917F70")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600008E")]
			[Address(RVA = "0x4F1EC0", Offset = "0x4F0AC0", VA = "0x1804F1EC0")]
			set
			{
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600008F RID: 143 RVA: 0x000023A0 File Offset: 0x000005A0
		// (set) Token: 0x06000090 RID: 144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000012")]
		public float outWeight
		{
			[Token(Token = "0x600008F")]
			[Address(RVA = "0x5917F60", Offset = "0x5916B60", VA = "0x185917F60")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000090")]
			[Address(RVA = "0x5B4660", Offset = "0x5B3260", VA = "0x1805B4660")]
			set
			{
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000091 RID: 145 RVA: 0x000023B8 File Offset: 0x000005B8
		// (set) Token: 0x06000092 RID: 146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000013")]
		public WeightedMode weightedMode
		{
			[Token(Token = "0x6000091")]
			[Address(RVA = "0x592C450", Offset = "0x592B050", VA = "0x18592C450")]
			get
			{
				return WeightedMode.None;
			}
			[Token(Token = "0x6000092")]
			[Address(RVA = "0x4EAC40", Offset = "0x4E9840", VA = "0x1804EAC40")]
			set
			{
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000093 RID: 147 RVA: 0x000023D0 File Offset: 0x000005D0
		// (set) Token: 0x06000094 RID: 148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000014")]
		[Obsolete("Use AnimationUtility.SetKeyLeftTangentMode, AnimationUtility.SetKeyRightTangentMode, AnimationUtility.GetKeyLeftTangentMode or AnimationUtility.GetKeyRightTangentMode instead.")]
		public int tangentMode
		{
			[Token(Token = "0x6000093")]
			[Address(RVA = "0x592C430", Offset = "0x592B030", VA = "0x18592C430")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000094")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
			set
			{
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000095 RID: 149 RVA: 0x000023E8 File Offset: 0x000005E8
		// (set) Token: 0x06000096 RID: 150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000015")]
		internal int tangentModeInternal
		{
			[Token(Token = "0x6000095")]
			[Address(RVA = "0x592C430", Offset = "0x592B030", VA = "0x18592C430")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000096")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
			set
			{
			}
		}

		// Token: 0x040000F4 RID: 244
		[Token(Token = "0x40000F4")]
		[FieldOffset(Offset = "0x0")]
		private float m_Time;

		// Token: 0x040000F5 RID: 245
		[Token(Token = "0x40000F5")]
		[FieldOffset(Offset = "0x4")]
		private float m_Value;

		// Token: 0x040000F6 RID: 246
		[Token(Token = "0x40000F6")]
		[FieldOffset(Offset = "0x8")]
		private float m_InTangent;

		// Token: 0x040000F7 RID: 247
		[Token(Token = "0x40000F7")]
		[FieldOffset(Offset = "0xC")]
		private float m_OutTangent;

		// Token: 0x040000F8 RID: 248
		[Token(Token = "0x40000F8")]
		[FieldOffset(Offset = "0x10")]
		private int m_WeightedMode;

		// Token: 0x040000F9 RID: 249
		[Token(Token = "0x40000F9")]
		[FieldOffset(Offset = "0x14")]
		private float m_InWeight;

		// Token: 0x040000FA RID: 250
		[Token(Token = "0x40000FA")]
		[FieldOffset(Offset = "0x18")]
		private float m_OutWeight;
	}
}
