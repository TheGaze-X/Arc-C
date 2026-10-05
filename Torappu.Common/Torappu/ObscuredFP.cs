using System;
using CodeStage.AntiCheat.ObscuredTypes;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu
{
	// Token: 0x02000098 RID: 152
	[Token(Token = "0x2000098")]
	[Serializable]
	public struct ObscuredFP : IEquatable<ObscuredFP>, IComparable<ObscuredFP>, IComparable<FP>, IComparable
	{
		// Token: 0x06000289 RID: 649 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000289")]
		[Address(RVA = "0x54EAC60", Offset = "0x54E9860", VA = "0x1854EAC60")]
		private ObscuredFP(FP value)
		{
		}

		// Token: 0x0600028A RID: 650 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600028A")]
		[Address(RVA = "0x54EAAB0", Offset = "0x54E96B0", VA = "0x1854EAAB0")]
		public static void SetNewCryptoKey(int newKey)
		{
		}

		// Token: 0x0600028B RID: 651 RVA: 0x0000395C File Offset: 0x00001B5C
		[Token(Token = "0x600028B")]
		[Address(RVA = "0x54EA880", Offset = "0x54E9480", VA = "0x1854EA880")]
		public FP Decrypt()
		{
			return default(FP);
		}

		// Token: 0x0600028C RID: 652 RVA: 0x00003974 File Offset: 0x00001B74
		[Token(Token = "0x600028C")]
		[Address(RVA = "0x54EABE0", Offset = "0x54E97E0", VA = "0x1854EABE0")]
		private FP _InternalDecrypt()
		{
			return default(FP);
		}

		// Token: 0x0600028D RID: 653 RVA: 0x0000398C File Offset: 0x00001B8C
		[Token(Token = "0x600028D")]
		[Address(RVA = "0x54EA390", Offset = "0x54E8F90", VA = "0x1854EA390")]
		public float AsFloat()
		{
			return 0f;
		}

		// Token: 0x0600028E RID: 654 RVA: 0x000039A4 File Offset: 0x00001BA4
		[Token(Token = "0x600028E")]
		[Address(RVA = "0x54EA420", Offset = "0x54E9020", VA = "0x1854EA420")]
		public int AsInt()
		{
			return 0;
		}

		// Token: 0x0600028F RID: 655 RVA: 0x000039BC File Offset: 0x00001BBC
		[Token(Token = "0x600028F")]
		[Address(RVA = "0x54EAEC0", Offset = "0x54E9AC0", VA = "0x1854EAEC0")]
		public static implicit operator ObscuredFP(FP value)
		{
			return default(ObscuredFP);
		}

		// Token: 0x06000290 RID: 656 RVA: 0x000039D4 File Offset: 0x00001BD4
		[Token(Token = "0x6000290")]
		[Address(RVA = "0x54EAF00", Offset = "0x54E9B00", VA = "0x1854EAF00")]
		public static implicit operator ObscuredFP(float value)
		{
			return default(ObscuredFP);
		}

		// Token: 0x06000291 RID: 657 RVA: 0x000039EC File Offset: 0x00001BEC
		[Token(Token = "0x6000291")]
		[Address(RVA = "0x54EAEF0", Offset = "0x54E9AF0", VA = "0x1854EAEF0")]
		public static implicit operator FP(ObscuredFP value)
		{
			return default(FP);
		}

		// Token: 0x06000292 RID: 658 RVA: 0x00003A04 File Offset: 0x00001C04
		[Token(Token = "0x6000292")]
		[Address(RVA = "0x54EAE30", Offset = "0x54E9A30", VA = "0x1854EAE30")]
		public static explicit operator float(ObscuredFP value)
		{
			return 0f;
		}

		// Token: 0x06000293 RID: 659 RVA: 0x00003A1C File Offset: 0x00001C1C
		[Token(Token = "0x6000293")]
		[Address(RVA = "0x54EACE0", Offset = "0x54E98E0", VA = "0x1854EACE0")]
		public static ObscuredFP operator +(ObscuredFP x, ObscuredFP y)
		{
			return default(ObscuredFP);
		}

		// Token: 0x06000294 RID: 660 RVA: 0x00003A34 File Offset: 0x00001C34
		[Token(Token = "0x6000294")]
		[Address(RVA = "0x54EB040", Offset = "0x54E9C40", VA = "0x1854EB040")]
		public static ObscuredFP operator -(ObscuredFP x, ObscuredFP y)
		{
			return default(ObscuredFP);
		}

		// Token: 0x06000295 RID: 661 RVA: 0x00003A4C File Offset: 0x00001C4C
		[Token(Token = "0x6000295")]
		[Address(RVA = "0x54EAF80", Offset = "0x54E9B80", VA = "0x1854EAF80")]
		public static ObscuredFP operator *(ObscuredFP x, ObscuredFP y)
		{
			return default(ObscuredFP);
		}

		// Token: 0x06000296 RID: 662 RVA: 0x00003A64 File Offset: 0x00001C64
		[Token(Token = "0x6000296")]
		[Address(RVA = "0x54EAD80", Offset = "0x54E9980", VA = "0x1854EAD80")]
		public static ObscuredFP operator /(ObscuredFP x, ObscuredFP y)
		{
			return default(ObscuredFP);
		}

		// Token: 0x06000297 RID: 663 RVA: 0x00003A7C File Offset: 0x00001C7C
		[Token(Token = "0x6000297")]
		[Address(RVA = "0x54EAA50", Offset = "0x54E9650", VA = "0x1854EAA50", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000298 RID: 664 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000298")]
		[Address(RVA = "0x54EAB40", Offset = "0x54E9740", VA = "0x1854EAB40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000299 RID: 665 RVA: 0x00003A94 File Offset: 0x00001C94
		[Token(Token = "0x6000299")]
		[Address(RVA = "0x54EA890", Offset = "0x54E9490", VA = "0x1854EA890", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x0600029A RID: 666 RVA: 0x00003AAC File Offset: 0x00001CAC
		[Token(Token = "0x600029A")]
		[Address(RVA = "0x54EA9E0", Offset = "0x54E95E0", VA = "0x1854EA9E0", Slot = "4")]
		public bool Equals(ObscuredFP obj)
		{
			return default(bool);
		}

		// Token: 0x0600029B RID: 667 RVA: 0x00003AC4 File Offset: 0x00001CC4
		[Token(Token = "0x600029B")]
		[Address(RVA = "0x54EA790", Offset = "0x54E9390", VA = "0x1854EA790", Slot = "5")]
		public int CompareTo(ObscuredFP other)
		{
			return 0;
		}

		// Token: 0x0600029C RID: 668 RVA: 0x00003ADC File Offset: 0x00001CDC
		[Token(Token = "0x600029C")]
		[Address(RVA = "0x54EA810", Offset = "0x54E9410", VA = "0x1854EA810", Slot = "6")]
		public int CompareTo(FP other)
		{
			return 0;
		}

		// Token: 0x0600029D RID: 669 RVA: 0x00003AF4 File Offset: 0x00001CF4
		[Token(Token = "0x600029D")]
		[Address(RVA = "0x54EA4B0", Offset = "0x54E90B0", VA = "0x1854EA4B0")]
		public int CompareTo(float other)
		{
			return 0;
		}

		// Token: 0x0600029E RID: 670 RVA: 0x00003B0C File Offset: 0x00001D0C
		[Token(Token = "0x600029E")]
		[Address(RVA = "0x54EA530", Offset = "0x54E9130", VA = "0x1854EA530", Slot = "7")]
		public int CompareTo(object obj)
		{
			return 0;
		}

		// Token: 0x040003CC RID: 972
		[Token(Token = "0x40003CC")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private ObscuredLong _serializedValue;
	}
}
