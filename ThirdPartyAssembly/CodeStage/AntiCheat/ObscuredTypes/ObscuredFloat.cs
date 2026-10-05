using System;
using System.Runtime.InteropServices;
using CodeStage.AntiCheat.Common;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	// Token: 0x02000570 RID: 1392
	[Token(Token = "0x2000570")]
	[Serializable]
	public struct ObscuredFloat : IFormattable, IEquatable<ObscuredFloat>, IComparable<ObscuredFloat>, IComparable<float>, IComparable
	{
		// Token: 0x06002E4D RID: 11853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E4D")]
		[Address(RVA = "0x5400660", Offset = "0x53FF260", VA = "0x185400660")]
		private ObscuredFloat(float value)
		{
		}

		// Token: 0x06002E4E RID: 11854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E4E")]
		[Address(RVA = "0x5400400", Offset = "0x53FF000", VA = "0x185400400")]
		public static void SetNewCryptoKey(int newKey)
		{
		}

		// Token: 0x06002E4F RID: 11855 RVA: 0x000136B0 File Offset: 0x000118B0
		[Token(Token = "0x6002E4F")]
		[Address(RVA = "0x53FFB30", Offset = "0x53FE730", VA = "0x1853FFB30")]
		public static int Encrypt(float value)
		{
			return 0;
		}

		// Token: 0x06002E50 RID: 11856 RVA: 0x000136C8 File Offset: 0x000118C8
		[Token(Token = "0x6002E50")]
		[Address(RVA = "0x53FFB00", Offset = "0x53FE700", VA = "0x1853FFB00")]
		public static int Encrypt(float value, int key)
		{
			return 0;
		}

		// Token: 0x06002E51 RID: 11857 RVA: 0x000136E0 File Offset: 0x000118E0
		[Token(Token = "0x6002E51")]
		[Address(RVA = "0x5400040", Offset = "0x53FEC40", VA = "0x185400040")]
		private static int InternalEncrypt(float value, int key = 0)
		{
			return 0;
		}

		// Token: 0x06002E52 RID: 11858 RVA: 0x000136F8 File Offset: 0x000118F8
		[Token(Token = "0x6002E52")]
		[Address(RVA = "0x53FFA50", Offset = "0x53FE650", VA = "0x1853FFA50")]
		public static float Decrypt(int value)
		{
			return 0f;
		}

		// Token: 0x06002E53 RID: 11859 RVA: 0x00013710 File Offset: 0x00011910
		[Token(Token = "0x6002E53")]
		[Address(RVA = "0x53FFAD0", Offset = "0x53FE6D0", VA = "0x1853FFAD0")]
		public static float Decrypt(int value, int key)
		{
			return 0f;
		}

		// Token: 0x06002E54 RID: 11860 RVA: 0x00013728 File Offset: 0x00011928
		[Token(Token = "0x6002E54")]
		[Address(RVA = "0x54000D0", Offset = "0x53FECD0", VA = "0x1854000D0")]
		public static int MigrateEncrypted(int encrypted, byte fromVersion = 0, byte toVersion = 2)
		{
			return 0;
		}

		// Token: 0x06002E55 RID: 11861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E55")]
		[Address(RVA = "0x53FF7D0", Offset = "0x53FE3D0", VA = "0x1853FF7D0")]
		public void ApplyNewCryptoKey()
		{
		}

		// Token: 0x06002E56 RID: 11862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E56")]
		[Address(RVA = "0x5400100", Offset = "0x53FED00", VA = "0x185400100")]
		public void RandomizeCryptoKey()
		{
		}

		// Token: 0x06002E57 RID: 11863 RVA: 0x00013740 File Offset: 0x00011940
		[Token(Token = "0x6002E57")]
		[Address(RVA = "0x53FFD90", Offset = "0x53FE990", VA = "0x1853FFD90")]
		public int GetEncrypted()
		{
			return 0;
		}

		// Token: 0x06002E58 RID: 11864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E58")]
		[Address(RVA = "0x5400180", Offset = "0x53FED80", VA = "0x185400180")]
		public void SetEncrypted(int encrypted)
		{
		}

		// Token: 0x06002E59 RID: 11865 RVA: 0x00013758 File Offset: 0x00011958
		[Token(Token = "0x6002E59")]
		[Address(RVA = "0x53FFD40", Offset = "0x53FE940", VA = "0x1853FFD40")]
		public float GetDecrypted()
		{
			return 0f;
		}

		// Token: 0x06002E5A RID: 11866 RVA: 0x00013770 File Offset: 0x00011970
		[Token(Token = "0x6002E5A")]
		[Address(RVA = "0x53FFE40", Offset = "0x53FEA40", VA = "0x1853FFE40")]
		private float InternalDecrypt()
		{
			return 0f;
		}

		// Token: 0x06002E5B RID: 11867 RVA: 0x00013788 File Offset: 0x00011988
		[Token(Token = "0x6002E5B")]
		[Address(RVA = "0x5400810", Offset = "0x53FF410", VA = "0x185400810")]
		public static implicit operator ObscuredFloat(float value)
		{
			return default(ObscuredFloat);
		}

		// Token: 0x06002E5C RID: 11868 RVA: 0x000137A0 File Offset: 0x000119A0
		[Token(Token = "0x6002E5C")]
		[Address(RVA = "0x5400840", Offset = "0x53FF440", VA = "0x185400840")]
		public static implicit operator float(ObscuredFloat value)
		{
			return 0f;
		}

		// Token: 0x06002E5D RID: 11869 RVA: 0x000137B8 File Offset: 0x000119B8
		[Token(Token = "0x6002E5D")]
		[Address(RVA = "0x5400890", Offset = "0x53FF490", VA = "0x185400890")]
		public static ObscuredFloat operator ++(ObscuredFloat input)
		{
			return default(ObscuredFloat);
		}

		// Token: 0x06002E5E RID: 11870 RVA: 0x000137D0 File Offset: 0x000119D0
		[Token(Token = "0x6002E5E")]
		[Address(RVA = "0x5400760", Offset = "0x53FF360", VA = "0x185400760")]
		public static ObscuredFloat operator --(ObscuredFloat input)
		{
			return default(ObscuredFloat);
		}

		// Token: 0x06002E5F RID: 11871 RVA: 0x000137E8 File Offset: 0x000119E8
		[Token(Token = "0x6002E5F")]
		[Address(RVA = "0x53FFDE0", Offset = "0x53FE9E0", VA = "0x1853FFDE0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002E60 RID: 11872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E60")]
		[Address(RVA = "0x5400540", Offset = "0x53FF140", VA = "0x185400540", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002E61 RID: 11873 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E61")]
		[Address(RVA = "0x5400460", Offset = "0x53FF060", VA = "0x185400460")]
		public string ToString(string format)
		{
			return null;
		}

		// Token: 0x06002E62 RID: 11874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E62")]
		[Address(RVA = "0x54004D0", Offset = "0x53FF0D0", VA = "0x1854004D0")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x06002E63 RID: 11875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E63")]
		[Address(RVA = "0x54005A0", Offset = "0x53FF1A0", VA = "0x1854005A0", Slot = "4")]
		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x06002E64 RID: 11876 RVA: 0x00013800 File Offset: 0x00011A00
		[Token(Token = "0x6002E64")]
		[Address(RVA = "0x53FFBB0", Offset = "0x53FE7B0", VA = "0x1853FFBB0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06002E65 RID: 11877 RVA: 0x00013818 File Offset: 0x00011A18
		[Token(Token = "0x6002E65")]
		[Address(RVA = "0x53FFCC0", Offset = "0x53FE8C0", VA = "0x1853FFCC0", Slot = "5")]
		public bool Equals(ObscuredFloat obj)
		{
			return default(bool);
		}

		// Token: 0x06002E66 RID: 11878 RVA: 0x00013830 File Offset: 0x00011A30
		[Token(Token = "0x6002E66")]
		[Address(RVA = "0x53FF8F0", Offset = "0x53FE4F0", VA = "0x1853FF8F0", Slot = "6")]
		public int CompareTo(ObscuredFloat other)
		{
			return 0;
		}

		// Token: 0x06002E67 RID: 11879 RVA: 0x00013848 File Offset: 0x00011A48
		[Token(Token = "0x6002E67")]
		[Address(RVA = "0x53FF9E0", Offset = "0x53FE5E0", VA = "0x1853FF9E0", Slot = "7")]
		public int CompareTo(float other)
		{
			return 0;
		}

		// Token: 0x06002E68 RID: 11880 RVA: 0x00013860 File Offset: 0x00011A60
		[Token(Token = "0x6002E68")]
		[Address(RVA = "0x53FF970", Offset = "0x53FE570", VA = "0x1853FF970", Slot = "8")]
		public int CompareTo(object obj)
		{
			return 0;
		}

		// Token: 0x040019E5 RID: 6629
		[Token(Token = "0x40019E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int cryptoKey;

		// Token: 0x040019E6 RID: 6630
		[Token(Token = "0x40019E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private int currentCryptoKey;

		// Token: 0x040019E7 RID: 6631
		[Token(Token = "0x40019E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[SerializeField]
		private int hiddenValue;

		// Token: 0x040019E8 RID: 6632
		[Token(Token = "0x40019E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[SerializeField]
		[FormerlySerializedAs("hiddenValue")]
		private ACTkByte4 hiddenValueOldByte4;

		// Token: 0x040019E9 RID: 6633
		[Token(Token = "0x40019E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[SerializeField]
		private bool inited;

		// Token: 0x040019EA RID: 6634
		[Token(Token = "0x40019EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private float fakeValue;

		// Token: 0x040019EB RID: 6635
		[Token(Token = "0x40019EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		private bool fakeValueActive;

		// Token: 0x02000571 RID: 1393
		[Token(Token = "0x2000571")]
		[StructLayout(2)]
		internal struct FloatIntBytesUnion
		{
			// Token: 0x040019EC RID: 6636
			[Token(Token = "0x40019EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float f;

			// Token: 0x040019ED RID: 6637
			[Token(Token = "0x40019ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int i;

			// Token: 0x040019EE RID: 6638
			[Token(Token = "0x40019EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ACTkByte4 b4;
		}
	}
}
