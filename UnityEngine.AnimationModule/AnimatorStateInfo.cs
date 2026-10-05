using System;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000013 RID: 19
	[Token(Token = "0x2000013")]
	[NativeHeader("Modules/Animation/AnimatorInfo.h")]
	[RequiredByNativeCode]
	public struct AnimatorStateInfo
	{
		// Token: 0x0600008A RID: 138 RVA: 0x00002190 File Offset: 0x00000390
		[Token(Token = "0x600008A")]
		[Address(RVA = "0x5917EE0", Offset = "0x5916AE0", VA = "0x185917EE0")]
		public bool IsName(string name)
		{
			return default(bool);
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600008B RID: 139 RVA: 0x000021A8 File Offset: 0x000003A8
		[Token(Token = "0x1700002A")]
		public int fullPathHash
		{
			[Token(Token = "0x600008B")]
			[Address(RVA = "0x4226DD0", Offset = "0x42259D0", VA = "0x184226DD0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600008C RID: 140 RVA: 0x000021C0 File Offset: 0x000003C0
		[Token(Token = "0x1700002B")]
		public float normalizedTime
		{
			[Token(Token = "0x600008C")]
			[Address(RVA = "0x5917F50", Offset = "0x5916B50", VA = "0x185917F50")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x0600008D RID: 141 RVA: 0x000021D8 File Offset: 0x000003D8
		[Token(Token = "0x1700002C")]
		public float length
		{
			[Token(Token = "0x600008D")]
			[Address(RVA = "0x5911BF0", Offset = "0x59107F0", VA = "0x185911BF0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600008E RID: 142 RVA: 0x000021F0 File Offset: 0x000003F0
		[Token(Token = "0x1700002D")]
		public float speed
		{
			[Token(Token = "0x600008E")]
			[Address(RVA = "0x5917F70", Offset = "0x5916B70", VA = "0x185917F70")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x0600008F RID: 143 RVA: 0x00002208 File Offset: 0x00000408
		[Token(Token = "0x1700002E")]
		public float speedMultiplier
		{
			[Token(Token = "0x600008F")]
			[Address(RVA = "0x5917F60", Offset = "0x5916B60", VA = "0x185917F60")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000090 RID: 144 RVA: 0x00002220 File Offset: 0x00000420
		[Token(Token = "0x1700002F")]
		public bool loop
		{
			[Token(Token = "0x6000090")]
			[Address(RVA = "0x5917F40", Offset = "0x5916B40", VA = "0x185917F40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x04000031 RID: 49
		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0x0")]
		private int m_Name;

		// Token: 0x04000032 RID: 50
		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0x4")]
		private int m_Path;

		// Token: 0x04000033 RID: 51
		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0x8")]
		private int m_FullPath;

		// Token: 0x04000034 RID: 52
		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0xC")]
		private float m_NormalizedTime;

		// Token: 0x04000035 RID: 53
		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0x10")]
		private float m_Length;

		// Token: 0x04000036 RID: 54
		[Token(Token = "0x4000036")]
		[FieldOffset(Offset = "0x14")]
		private float m_Speed;

		// Token: 0x04000037 RID: 55
		[Token(Token = "0x4000037")]
		[FieldOffset(Offset = "0x18")]
		private float m_SpeedMultiplier;

		// Token: 0x04000038 RID: 56
		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0x1C")]
		private int m_Tag;

		// Token: 0x04000039 RID: 57
		[Token(Token = "0x4000039")]
		[FieldOffset(Offset = "0x20")]
		private int m_Loop;
	}
}
