using System;
using Il2CppDummyDll;
using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	// Token: 0x02000582 RID: 1410
	[Token(Token = "0x2000582")]
	[Serializable]
	public struct ObscuredVector2Int
	{
		// Token: 0x06002FE1 RID: 12257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FE1")]
		[Address(RVA = "0x5412840", Offset = "0x5411440", VA = "0x185412840")]
		private ObscuredVector2Int(Vector2Int value)
		{
		}

		// Token: 0x06002FE2 RID: 12258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FE2")]
		[Address(RVA = "0x54126E0", Offset = "0x54112E0", VA = "0x1854126E0")]
		public ObscuredVector2Int(int x, int y)
		{
		}

		// Token: 0x170006EE RID: 1774
		// (get) Token: 0x06002FE3 RID: 12259 RVA: 0x00014B50 File Offset: 0x00012D50
		// (set) Token: 0x06002FE4 RID: 12260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006EE")]
		public int x
		{
			[Token(Token = "0x6002FE3")]
			[Address(RVA = "0x54129E0", Offset = "0x54115E0", VA = "0x1854129E0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002FE4")]
			[Address(RVA = "0x5412DC0", Offset = "0x54119C0", VA = "0x185412DC0")]
			set
			{
			}
		}

		// Token: 0x170006EF RID: 1775
		// (get) Token: 0x06002FE5 RID: 12261 RVA: 0x00014B68 File Offset: 0x00012D68
		// (set) Token: 0x06002FE6 RID: 12262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006EF")]
		public int y
		{
			[Token(Token = "0x6002FE5")]
			[Address(RVA = "0x5412AE0", Offset = "0x54116E0", VA = "0x185412AE0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002FE6")]
			[Address(RVA = "0x5412E70", Offset = "0x5411A70", VA = "0x185412E70")]
			set
			{
			}
		}

		// Token: 0x170006F0 RID: 1776
		[Token(Token = "0x170006F0")]
		public int this[int index]
		{
			[Token(Token = "0x6002FE7")]
			[Address(RVA = "0x5412900", Offset = "0x5411500", VA = "0x185412900")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002FE8")]
			[Address(RVA = "0x5412CD0", Offset = "0x54118D0", VA = "0x185412CD0")]
			set
			{
			}
		}

		// Token: 0x06002FE9 RID: 12265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FE9")]
		[Address(RVA = "0x54125A0", Offset = "0x54111A0", VA = "0x1854125A0")]
		public static void SetNewCryptoKey(int newKey)
		{
		}

		// Token: 0x06002FEA RID: 12266 RVA: 0x00014B98 File Offset: 0x00012D98
		[Token(Token = "0x6002FEA")]
		[Address(RVA = "0x5411DB0", Offset = "0x54109B0", VA = "0x185411DB0")]
		public static ObscuredVector2Int.RawEncryptedVector2Int Encrypt(Vector2Int value)
		{
			return default(ObscuredVector2Int.RawEncryptedVector2Int);
		}

		// Token: 0x06002FEB RID: 12267 RVA: 0x00014BB0 File Offset: 0x00012DB0
		[Token(Token = "0x6002FEB")]
		[Address(RVA = "0x5411D50", Offset = "0x5410950", VA = "0x185411D50")]
		public static ObscuredVector2Int.RawEncryptedVector2Int Encrypt(Vector2Int value, int key)
		{
			return default(ObscuredVector2Int.RawEncryptedVector2Int);
		}

		// Token: 0x06002FEC RID: 12268 RVA: 0x00014BC8 File Offset: 0x00012DC8
		[Token(Token = "0x6002FEC")]
		[Address(RVA = "0x5411E40", Offset = "0x5410A40", VA = "0x185411E40")]
		public static ObscuredVector2Int.RawEncryptedVector2Int Encrypt(int x, int y, int key)
		{
			return default(ObscuredVector2Int.RawEncryptedVector2Int);
		}

		// Token: 0x06002FED RID: 12269 RVA: 0x00014BE0 File Offset: 0x00012DE0
		[Token(Token = "0x6002FED")]
		[Address(RVA = "0x5411BF0", Offset = "0x54107F0", VA = "0x185411BF0")]
		public static Vector2Int Decrypt(ObscuredVector2Int.RawEncryptedVector2Int value)
		{
			return default(Vector2Int);
		}

		// Token: 0x06002FEE RID: 12270 RVA: 0x00014BF8 File Offset: 0x00012DF8
		[Token(Token = "0x6002FEE")]
		[Address(RVA = "0x5411B40", Offset = "0x5410740", VA = "0x185411B40")]
		public static Vector2Int Decrypt(ObscuredVector2Int.RawEncryptedVector2Int value, int key)
		{
			return default(Vector2Int);
		}

		// Token: 0x06002FEF RID: 12271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FEF")]
		[Address(RVA = "0x5411A40", Offset = "0x5410640", VA = "0x185411A40")]
		public void ApplyNewCryptoKey()
		{
		}

		// Token: 0x06002FF0 RID: 12272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FF0")]
		[Address(RVA = "0x54122B0", Offset = "0x5410EB0", VA = "0x1854122B0")]
		public void RandomizeCryptoKey()
		{
		}

		// Token: 0x06002FF1 RID: 12273 RVA: 0x00014C10 File Offset: 0x00012E10
		[Token(Token = "0x6002FF1")]
		[Address(RVA = "0x5411F50", Offset = "0x5410B50", VA = "0x185411F50")]
		public ObscuredVector2Int.RawEncryptedVector2Int GetEncrypted()
		{
			return default(ObscuredVector2Int.RawEncryptedVector2Int);
		}

		// Token: 0x06002FF2 RID: 12274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FF2")]
		[Address(RVA = "0x54123A0", Offset = "0x5410FA0", VA = "0x1854123A0")]
		public void SetEncrypted(ObscuredVector2Int.RawEncryptedVector2Int encrypted)
		{
		}

		// Token: 0x06002FF3 RID: 12275 RVA: 0x00014C28 File Offset: 0x00012E28
		[Token(Token = "0x6002FF3")]
		[Address(RVA = "0x5411F00", Offset = "0x5410B00", VA = "0x185411F00")]
		public Vector2Int GetDecrypted()
		{
			return default(Vector2Int);
		}

		// Token: 0x06002FF4 RID: 12276 RVA: 0x00014C40 File Offset: 0x00012E40
		[Token(Token = "0x6002FF4")]
		[Address(RVA = "0x54120B0", Offset = "0x5410CB0", VA = "0x1854120B0")]
		private Vector2Int InternalDecrypt()
		{
			return default(Vector2Int);
		}

		// Token: 0x06002FF5 RID: 12277 RVA: 0x00014C58 File Offset: 0x00012E58
		[Token(Token = "0x6002FF5")]
		[Address(RVA = "0x5412020", Offset = "0x5410C20", VA = "0x185412020")]
		private int InternalDecryptField(int encrypted)
		{
			return 0;
		}

		// Token: 0x06002FF6 RID: 12278 RVA: 0x00014C70 File Offset: 0x00012E70
		[Token(Token = "0x6002FF6")]
		[Address(RVA = "0x5412220", Offset = "0x5410E20", VA = "0x185412220")]
		private int InternalEncryptField(int encrypted)
		{
			return 0;
		}

		// Token: 0x06002FF7 RID: 12279 RVA: 0x00014C88 File Offset: 0x00012E88
		[Token(Token = "0x6002FF7")]
		[Address(RVA = "0x5412C30", Offset = "0x5411830", VA = "0x185412C30")]
		public static implicit operator ObscuredVector2Int(Vector2Int value)
		{
			return default(ObscuredVector2Int);
		}

		// Token: 0x06002FF8 RID: 12280 RVA: 0x00014CA0 File Offset: 0x00012EA0
		[Token(Token = "0x6002FF8")]
		[Address(RVA = "0x5412BE0", Offset = "0x54117E0", VA = "0x185412BE0")]
		public static implicit operator Vector2Int(ObscuredVector2Int value)
		{
			return default(Vector2Int);
		}

		// Token: 0x06002FF9 RID: 12281 RVA: 0x00014CB8 File Offset: 0x00012EB8
		[Token(Token = "0x6002FF9")]
		[Address(RVA = "0x5412C60", Offset = "0x5411860", VA = "0x185412C60")]
		public static implicit operator Vector2(ObscuredVector2Int value)
		{
			return default(Vector2);
		}

		// Token: 0x06002FFA RID: 12282 RVA: 0x00014CD0 File Offset: 0x00012ED0
		[Token(Token = "0x6002FFA")]
		[Address(RVA = "0x5411FA0", Offset = "0x5410BA0", VA = "0x185411FA0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002FFB RID: 12283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FFB")]
		[Address(RVA = "0x5412600", Offset = "0x5411200", VA = "0x185412600", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04001A57 RID: 6743
		[Token(Token = "0x4001A57")]
		[FieldOffset(Offset = "0x0")]
		private static int cryptoKey;

		// Token: 0x04001A58 RID: 6744
		[Token(Token = "0x4001A58")]
		[FieldOffset(Offset = "0x4")]
		private static readonly Vector2Int zero;

		// Token: 0x04001A59 RID: 6745
		[Token(Token = "0x4001A59")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private int currentCryptoKey;

		// Token: 0x04001A5A RID: 6746
		[Token(Token = "0x4001A5A")]
		[FieldOffset(Offset = "0x4")]
		[SerializeField]
		private ObscuredVector2Int.RawEncryptedVector2Int hiddenValue;

		// Token: 0x04001A5B RID: 6747
		[Token(Token = "0x4001A5B")]
		[FieldOffset(Offset = "0xC")]
		[SerializeField]
		private bool inited;

		// Token: 0x04001A5C RID: 6748
		[Token(Token = "0x4001A5C")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Vector2Int fakeValue;

		// Token: 0x04001A5D RID: 6749
		[Token(Token = "0x4001A5D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool fakeValueActive;

		// Token: 0x02000583 RID: 1411
		[Token(Token = "0x2000583")]
		[Serializable]
		public struct RawEncryptedVector2Int
		{
			// Token: 0x04001A5E RID: 6750
			[Token(Token = "0x4001A5E")]
			[FieldOffset(Offset = "0x0")]
			public int x;

			// Token: 0x04001A5F RID: 6751
			[Token(Token = "0x4001A5F")]
			[FieldOffset(Offset = "0x4")]
			public int y;
		}
	}
}
