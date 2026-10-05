using System;
using Il2CppDummyDll;
using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	// Token: 0x02000578 RID: 1400
	[Token(Token = "0x2000578")]
	[Serializable]
	public struct ObscuredQuaternion
	{
		// Token: 0x06002F0E RID: 12046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F0E")]
		[Address(RVA = "0x540B8D0", Offset = "0x540A4D0", VA = "0x18540B8D0")]
		private ObscuredQuaternion(Quaternion value)
		{
		}

		// Token: 0x06002F0F RID: 12047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F0F")]
		[Address(RVA = "0x540B7A0", Offset = "0x540A3A0", VA = "0x18540B7A0")]
		public ObscuredQuaternion(float x, float y, float z, float w)
		{
		}

		// Token: 0x06002F10 RID: 12048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F10")]
		[Address(RVA = "0x540B5D0", Offset = "0x540A1D0", VA = "0x18540B5D0")]
		public static void SetNewCryptoKey(int newKey)
		{
		}

		// Token: 0x06002F11 RID: 12049 RVA: 0x00013FF8 File Offset: 0x000121F8
		[Token(Token = "0x6002F11")]
		[Address(RVA = "0x540AD00", Offset = "0x5409900", VA = "0x18540AD00")]
		public static ObscuredQuaternion.RawEncryptedQuaternion Encrypt(Quaternion value)
		{
			return default(ObscuredQuaternion.RawEncryptedQuaternion);
		}

		// Token: 0x06002F12 RID: 12050 RVA: 0x00014010 File Offset: 0x00012210
		[Token(Token = "0x6002F12")]
		[Address(RVA = "0x540ADD0", Offset = "0x54099D0", VA = "0x18540ADD0")]
		public static ObscuredQuaternion.RawEncryptedQuaternion Encrypt(Quaternion value, int key)
		{
			return default(ObscuredQuaternion.RawEncryptedQuaternion);
		}

		// Token: 0x06002F13 RID: 12051 RVA: 0x00014028 File Offset: 0x00012228
		[Token(Token = "0x6002F13")]
		[Address(RVA = "0x540AE70", Offset = "0x5409A70", VA = "0x18540AE70")]
		public static ObscuredQuaternion.RawEncryptedQuaternion Encrypt(float x, float y, float z, float w, int key)
		{
			return default(ObscuredQuaternion.RawEncryptedQuaternion);
		}

		// Token: 0x06002F14 RID: 12052 RVA: 0x00014040 File Offset: 0x00012240
		[Token(Token = "0x6002F14")]
		[Address(RVA = "0x540AB80", Offset = "0x5409780", VA = "0x18540AB80")]
		public static Quaternion Decrypt(ObscuredQuaternion.RawEncryptedQuaternion value)
		{
			return default(Quaternion);
		}

		// Token: 0x06002F15 RID: 12053 RVA: 0x00014058 File Offset: 0x00012258
		[Token(Token = "0x6002F15")]
		[Address(RVA = "0x540AA50", Offset = "0x5409650", VA = "0x18540AA50")]
		public static Quaternion Decrypt(ObscuredQuaternion.RawEncryptedQuaternion value, int key)
		{
			return default(Quaternion);
		}

		// Token: 0x06002F16 RID: 12054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F16")]
		[Address(RVA = "0x540A7E0", Offset = "0x54093E0", VA = "0x18540A7E0")]
		public void ApplyNewCryptoKey()
		{
		}

		// Token: 0x06002F17 RID: 12055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F17")]
		[Address(RVA = "0x540B410", Offset = "0x540A010", VA = "0x18540B410")]
		public void RandomizeCryptoKey()
		{
		}

		// Token: 0x06002F18 RID: 12056 RVA: 0x00014070 File Offset: 0x00012270
		[Token(Token = "0x6002F18")]
		[Address(RVA = "0x540B050", Offset = "0x5409C50", VA = "0x18540B050")]
		public ObscuredQuaternion.RawEncryptedQuaternion GetEncrypted()
		{
			return default(ObscuredQuaternion.RawEncryptedQuaternion);
		}

		// Token: 0x06002F19 RID: 12057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F19")]
		[Address(RVA = "0x540B520", Offset = "0x540A120", VA = "0x18540B520")]
		public void SetEncrypted(ObscuredQuaternion.RawEncryptedQuaternion encrypted)
		{
		}

		// Token: 0x06002F1A RID: 12058 RVA: 0x00014088 File Offset: 0x00012288
		[Token(Token = "0x6002F1A")]
		[Address(RVA = "0x540AFE0", Offset = "0x5409BE0", VA = "0x18540AFE0")]
		public Quaternion GetDecrypted()
		{
			return default(Quaternion);
		}

		// Token: 0x06002F1B RID: 12059 RVA: 0x000140A0 File Offset: 0x000122A0
		[Token(Token = "0x6002F1B")]
		[Address(RVA = "0x540B170", Offset = "0x5409D70", VA = "0x18540B170")]
		private Quaternion InternalDecrypt()
		{
			return default(Quaternion);
		}

		// Token: 0x06002F1C RID: 12060 RVA: 0x000140B8 File Offset: 0x000122B8
		[Token(Token = "0x6002F1C")]
		[Address(RVA = "0x540A900", Offset = "0x5409500", VA = "0x18540A900")]
		private bool CompareQuaternionsWithTolerance(Quaternion q1, Quaternion q2)
		{
			return default(bool);
		}

		// Token: 0x06002F1D RID: 12061 RVA: 0x000140D0 File Offset: 0x000122D0
		[Token(Token = "0x6002F1D")]
		[Address(RVA = "0x540BA30", Offset = "0x540A630", VA = "0x18540BA30")]
		public static implicit operator ObscuredQuaternion(Quaternion value)
		{
			return default(ObscuredQuaternion);
		}

		// Token: 0x06002F1E RID: 12062 RVA: 0x000140E8 File Offset: 0x000122E8
		[Token(Token = "0x6002F1E")]
		[Address(RVA = "0x540BA70", Offset = "0x540A670", VA = "0x18540BA70")]
		public static implicit operator Quaternion(ObscuredQuaternion value)
		{
			return default(Quaternion);
		}

		// Token: 0x06002F1F RID: 12063 RVA: 0x00014100 File Offset: 0x00012300
		[Token(Token = "0x6002F1F")]
		[Address(RVA = "0x540B0B0", Offset = "0x5409CB0", VA = "0x18540B0B0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002F20 RID: 12064 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F20")]
		[Address(RVA = "0x540B630", Offset = "0x540A230", VA = "0x18540B630", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002F21 RID: 12065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F21")]
		[Address(RVA = "0x540B6A0", Offset = "0x540A2A0", VA = "0x18540B6A0")]
		public string ToString(string format)
		{
			return null;
		}

		// Token: 0x04001A1F RID: 6687
		[Token(Token = "0x4001A1F")]
		[FieldOffset(Offset = "0x0")]
		private static int cryptoKey;

		// Token: 0x04001A20 RID: 6688
		[Token(Token = "0x4001A20")]
		[FieldOffset(Offset = "0x4")]
		private static readonly Quaternion identity;

		// Token: 0x04001A21 RID: 6689
		[Token(Token = "0x4001A21")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private int currentCryptoKey;

		// Token: 0x04001A22 RID: 6690
		[Token(Token = "0x4001A22")]
		[FieldOffset(Offset = "0x4")]
		[SerializeField]
		private ObscuredQuaternion.RawEncryptedQuaternion hiddenValue;

		// Token: 0x04001A23 RID: 6691
		[Token(Token = "0x4001A23")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private bool inited;

		// Token: 0x04001A24 RID: 6692
		[Token(Token = "0x4001A24")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Quaternion fakeValue;

		// Token: 0x04001A25 RID: 6693
		[Token(Token = "0x4001A25")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool fakeValueActive;

		// Token: 0x02000579 RID: 1401
		[Token(Token = "0x2000579")]
		[Serializable]
		public struct RawEncryptedQuaternion
		{
			// Token: 0x04001A26 RID: 6694
			[Token(Token = "0x4001A26")]
			[FieldOffset(Offset = "0x0")]
			public int x;

			// Token: 0x04001A27 RID: 6695
			[Token(Token = "0x4001A27")]
			[FieldOffset(Offset = "0x4")]
			public int y;

			// Token: 0x04001A28 RID: 6696
			[Token(Token = "0x4001A28")]
			[FieldOffset(Offset = "0x8")]
			public int z;

			// Token: 0x04001A29 RID: 6697
			[Token(Token = "0x4001A29")]
			[FieldOffset(Offset = "0xC")]
			public int w;
		}
	}
}
