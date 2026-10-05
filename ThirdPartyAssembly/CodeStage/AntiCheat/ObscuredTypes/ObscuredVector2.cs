using System;
using Il2CppDummyDll;
using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	// Token: 0x02000580 RID: 1408
	[Token(Token = "0x2000580")]
	[Serializable]
	public struct ObscuredVector2
	{
		// Token: 0x06002FC3 RID: 12227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FC3")]
		[Address(RVA = "0x5413EB0", Offset = "0x5412AB0", VA = "0x185413EB0")]
		private ObscuredVector2(Vector2 value)
		{
		}

		// Token: 0x06002FC4 RID: 12228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FC4")]
		[Address(RVA = "0x5413DD0", Offset = "0x54129D0", VA = "0x185413DD0")]
		public ObscuredVector2(float x, float y)
		{
		}

		// Token: 0x170006EB RID: 1771
		// (get) Token: 0x06002FC5 RID: 12229 RVA: 0x000149A0 File Offset: 0x00012BA0
		// (set) Token: 0x06002FC6 RID: 12230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006EB")]
		public float x
		{
			[Token(Token = "0x6002FC5")]
			[Address(RVA = "0x5414080", Offset = "0x5412C80", VA = "0x185414080")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6002FC6")]
			[Address(RVA = "0x5414550", Offset = "0x5413150", VA = "0x185414550")]
			set
			{
			}
		}

		// Token: 0x170006EC RID: 1772
		// (get) Token: 0x06002FC7 RID: 12231 RVA: 0x000149B8 File Offset: 0x00012BB8
		// (set) Token: 0x06002FC8 RID: 12232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006EC")]
		public float y
		{
			[Token(Token = "0x6002FC7")]
			[Address(RVA = "0x54141F0", Offset = "0x5412DF0", VA = "0x1854141F0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6002FC8")]
			[Address(RVA = "0x5414610", Offset = "0x5413210", VA = "0x185414610")]
			set
			{
			}
		}

		// Token: 0x170006ED RID: 1773
		[Token(Token = "0x170006ED")]
		public float this[int index]
		{
			[Token(Token = "0x6002FC9")]
			[Address(RVA = "0x5413FA0", Offset = "0x5412BA0", VA = "0x185413FA0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6002FCA")]
			[Address(RVA = "0x5414460", Offset = "0x5413060", VA = "0x185414460")]
			set
			{
			}
		}

		// Token: 0x06002FCB RID: 12235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FCB")]
		[Address(RVA = "0x5413C10", Offset = "0x5412810", VA = "0x185413C10")]
		public static void SetNewCryptoKey(int newKey)
		{
		}

		// Token: 0x06002FCC RID: 12236 RVA: 0x000149E8 File Offset: 0x00012BE8
		[Token(Token = "0x6002FCC")]
		[Address(RVA = "0x5413400", Offset = "0x5412000", VA = "0x185413400")]
		public static ObscuredVector2.RawEncryptedVector2 Encrypt(Vector2 value)
		{
			return default(ObscuredVector2.RawEncryptedVector2);
		}

		// Token: 0x06002FCD RID: 12237 RVA: 0x00014A00 File Offset: 0x00012C00
		[Token(Token = "0x6002FCD")]
		[Address(RVA = "0x54133A0", Offset = "0x5411FA0", VA = "0x1854133A0")]
		public static ObscuredVector2.RawEncryptedVector2 Encrypt(Vector2 value, int key)
		{
			return default(ObscuredVector2.RawEncryptedVector2);
		}

		// Token: 0x06002FCE RID: 12238 RVA: 0x00014A18 File Offset: 0x00012C18
		[Token(Token = "0x6002FCE")]
		[Address(RVA = "0x54132C0", Offset = "0x5411EC0", VA = "0x1854132C0")]
		public static ObscuredVector2.RawEncryptedVector2 Encrypt(float x, float y, int key)
		{
			return default(ObscuredVector2.RawEncryptedVector2);
		}

		// Token: 0x06002FCF RID: 12239 RVA: 0x00014A30 File Offset: 0x00012C30
		[Token(Token = "0x6002FCF")]
		[Address(RVA = "0x54130F0", Offset = "0x5411CF0", VA = "0x1854130F0")]
		public static Vector2 Decrypt(ObscuredVector2.RawEncryptedVector2 value)
		{
			return default(Vector2);
		}

		// Token: 0x06002FD0 RID: 12240 RVA: 0x00014A48 File Offset: 0x00012C48
		[Token(Token = "0x6002FD0")]
		[Address(RVA = "0x54131F0", Offset = "0x5411DF0", VA = "0x1854131F0")]
		public static Vector2 Decrypt(ObscuredVector2.RawEncryptedVector2 value, int key)
		{
			return default(Vector2);
		}

		// Token: 0x06002FD1 RID: 12241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FD1")]
		[Address(RVA = "0x5412F20", Offset = "0x5411B20", VA = "0x185412F20")]
		public void ApplyNewCryptoKey()
		{
		}

		// Token: 0x06002FD2 RID: 12242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FD2")]
		[Address(RVA = "0x54138C0", Offset = "0x54124C0", VA = "0x1854138C0")]
		public void RandomizeCryptoKey()
		{
		}

		// Token: 0x06002FD3 RID: 12243 RVA: 0x00014A60 File Offset: 0x00012C60
		[Token(Token = "0x6002FD3")]
		[Address(RVA = "0x54134E0", Offset = "0x54120E0", VA = "0x1854134E0")]
		public ObscuredVector2.RawEncryptedVector2 GetEncrypted()
		{
			return default(ObscuredVector2.RawEncryptedVector2);
		}

		// Token: 0x06002FD4 RID: 12244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FD4")]
		[Address(RVA = "0x54139A0", Offset = "0x54125A0", VA = "0x1854139A0")]
		public void SetEncrypted(ObscuredVector2.RawEncryptedVector2 encrypted)
		{
		}

		// Token: 0x06002FD5 RID: 12245 RVA: 0x00014A78 File Offset: 0x00012C78
		[Token(Token = "0x6002FD5")]
		[Address(RVA = "0x5413490", Offset = "0x5412090", VA = "0x185413490")]
		public Vector2 GetDecrypted()
		{
			return default(Vector2);
		}

		// Token: 0x06002FD6 RID: 12246 RVA: 0x00014A90 File Offset: 0x00012C90
		[Token(Token = "0x6002FD6")]
		[Address(RVA = "0x5413640", Offset = "0x5412240", VA = "0x185413640")]
		private Vector2 InternalDecrypt()
		{
			return default(Vector2);
		}

		// Token: 0x06002FD7 RID: 12247 RVA: 0x00014AA8 File Offset: 0x00012CA8
		[Token(Token = "0x6002FD7")]
		[Address(RVA = "0x5413010", Offset = "0x5411C10", VA = "0x185413010")]
		private bool CompareVectorsWithTolerance(Vector2 vector1, Vector2 vector2)
		{
			return default(bool);
		}

		// Token: 0x06002FD8 RID: 12248 RVA: 0x00014AC0 File Offset: 0x00012CC0
		[Token(Token = "0x6002FD8")]
		[Address(RVA = "0x54135A0", Offset = "0x54121A0", VA = "0x1854135A0")]
		private float InternalDecryptField(int encrypted)
		{
			return 0f;
		}

		// Token: 0x06002FD9 RID: 12249 RVA: 0x00014AD8 File Offset: 0x00012CD8
		[Token(Token = "0x6002FD9")]
		[Address(RVA = "0x5413820", Offset = "0x5412420", VA = "0x185413820")]
		private int InternalEncryptField(float encrypted)
		{
			return 0;
		}

		// Token: 0x06002FDA RID: 12250 RVA: 0x00014AF0 File Offset: 0x00012CF0
		[Token(Token = "0x6002FDA")]
		[Address(RVA = "0x5414430", Offset = "0x5413030", VA = "0x185414430")]
		public static implicit operator ObscuredVector2(Vector2 value)
		{
			return default(ObscuredVector2);
		}

		// Token: 0x06002FDB RID: 12251 RVA: 0x00014B08 File Offset: 0x00012D08
		[Token(Token = "0x6002FDB")]
		[Address(RVA = "0x5414360", Offset = "0x5412F60", VA = "0x185414360")]
		public static implicit operator Vector2(ObscuredVector2 value)
		{
			return default(Vector2);
		}

		// Token: 0x06002FDC RID: 12252 RVA: 0x00014B20 File Offset: 0x00012D20
		[Token(Token = "0x6002FDC")]
		[Address(RVA = "0x54143B0", Offset = "0x5412FB0", VA = "0x1854143B0")]
		public static implicit operator Vector3(ObscuredVector2 value)
		{
			return default(Vector3);
		}

		// Token: 0x06002FDD RID: 12253 RVA: 0x00014B38 File Offset: 0x00012D38
		[Token(Token = "0x6002FDD")]
		[Address(RVA = "0x5413530", Offset = "0x5412130", VA = "0x185413530", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002FDE RID: 12254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FDE")]
		[Address(RVA = "0x5413CE0", Offset = "0x54128E0", VA = "0x185413CE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002FDF RID: 12255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FDF")]
		[Address(RVA = "0x5413C70", Offset = "0x5412870", VA = "0x185413C70")]
		public string ToString(string format)
		{
			return null;
		}

		// Token: 0x04001A4E RID: 6734
		[Token(Token = "0x4001A4E")]
		[FieldOffset(Offset = "0x0")]
		private static int cryptoKey;

		// Token: 0x04001A4F RID: 6735
		[Token(Token = "0x4001A4F")]
		[FieldOffset(Offset = "0x4")]
		private static readonly Vector2 zero;

		// Token: 0x04001A50 RID: 6736
		[Token(Token = "0x4001A50")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private int currentCryptoKey;

		// Token: 0x04001A51 RID: 6737
		[Token(Token = "0x4001A51")]
		[FieldOffset(Offset = "0x4")]
		[SerializeField]
		private ObscuredVector2.RawEncryptedVector2 hiddenValue;

		// Token: 0x04001A52 RID: 6738
		[Token(Token = "0x4001A52")]
		[FieldOffset(Offset = "0xC")]
		[SerializeField]
		private bool inited;

		// Token: 0x04001A53 RID: 6739
		[Token(Token = "0x4001A53")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Vector2 fakeValue;

		// Token: 0x04001A54 RID: 6740
		[Token(Token = "0x4001A54")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool fakeValueActive;

		// Token: 0x02000581 RID: 1409
		[Token(Token = "0x2000581")]
		[Serializable]
		public struct RawEncryptedVector2
		{
			// Token: 0x04001A55 RID: 6741
			[Token(Token = "0x4001A55")]
			[FieldOffset(Offset = "0x0")]
			public int x;

			// Token: 0x04001A56 RID: 6742
			[Token(Token = "0x4001A56")]
			[FieldOffset(Offset = "0x4")]
			public int y;
		}
	}
}
