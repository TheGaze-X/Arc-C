using System;
using Il2CppDummyDll;
using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	// Token: 0x02000586 RID: 1414
	[Token(Token = "0x2000586")]
	[Serializable]
	public struct ObscuredVector3Int
	{
		// Token: 0x0600302D RID: 12333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600302D")]
		[Address(RVA = "0x5415990", Offset = "0x5414590", VA = "0x185415990")]
		private ObscuredVector3Int(Vector3Int value)
		{
		}

		// Token: 0x0600302E RID: 12334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600302E")]
		[Address(RVA = "0x5415C30", Offset = "0x5414830", VA = "0x185415C30")]
		public ObscuredVector3Int(int x, int y, int z)
		{
		}

		// Token: 0x170006F5 RID: 1781
		// (get) Token: 0x0600302F RID: 12335 RVA: 0x00015030 File Offset: 0x00013230
		// (set) Token: 0x06003030 RID: 12336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006F5")]
		public int x
		{
			[Token(Token = "0x600302F")]
			[Address(RVA = "0x5415ED0", Offset = "0x5414AD0", VA = "0x185415ED0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6003030")]
			[Address(RVA = "0x5416FE0", Offset = "0x5415BE0", VA = "0x185416FE0")]
			set
			{
			}
		}

		// Token: 0x170006F6 RID: 1782
		// (get) Token: 0x06003031 RID: 12337 RVA: 0x00015048 File Offset: 0x00013248
		// (set) Token: 0x06003032 RID: 12338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006F6")]
		public int y
		{
			[Token(Token = "0x6003031")]
			[Address(RVA = "0x5415FD0", Offset = "0x5414BD0", VA = "0x185415FD0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6003032")]
			[Address(RVA = "0x54170A0", Offset = "0x5415CA0", VA = "0x1854170A0")]
			set
			{
			}
		}

		// Token: 0x170006F7 RID: 1783
		// (get) Token: 0x06003033 RID: 12339 RVA: 0x00015060 File Offset: 0x00013260
		// (set) Token: 0x06003034 RID: 12340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006F7")]
		public int z
		{
			[Token(Token = "0x6003033")]
			[Address(RVA = "0x54160D0", Offset = "0x5414CD0", VA = "0x1854160D0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6003034")]
			[Address(RVA = "0x5417160", Offset = "0x5415D60", VA = "0x185417160")]
			set
			{
			}
		}

		// Token: 0x170006F8 RID: 1784
		[Token(Token = "0x170006F8")]
		public int this[int index]
		{
			[Token(Token = "0x6003035")]
			[Address(RVA = "0x5415DC0", Offset = "0x54149C0", VA = "0x185415DC0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6003036")]
			[Address(RVA = "0x5416EB0", Offset = "0x5415AB0", VA = "0x185416EB0")]
			set
			{
			}
		}

		// Token: 0x06003037 RID: 12343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003037")]
		[Address(RVA = "0x54157B0", Offset = "0x54143B0", VA = "0x1854157B0")]
		public static void SetNewCryptoKey(int newKey)
		{
		}

		// Token: 0x06003038 RID: 12344 RVA: 0x00015090 File Offset: 0x00013290
		[Token(Token = "0x6003038")]
		[Address(RVA = "0x5414AB0", Offset = "0x54136B0", VA = "0x185414AB0")]
		public static ObscuredVector3Int.RawEncryptedVector3Int Encrypt(Vector3Int value)
		{
			return default(ObscuredVector3Int.RawEncryptedVector3Int);
		}

		// Token: 0x06003039 RID: 12345 RVA: 0x000150A8 File Offset: 0x000132A8
		[Token(Token = "0x6003039")]
		[Address(RVA = "0x5414CB0", Offset = "0x54138B0", VA = "0x185414CB0")]
		public static ObscuredVector3Int.RawEncryptedVector3Int Encrypt(Vector3Int value, int key)
		{
			return default(ObscuredVector3Int.RawEncryptedVector3Int);
		}

		// Token: 0x0600303A RID: 12346 RVA: 0x000150C0 File Offset: 0x000132C0
		[Token(Token = "0x600303A")]
		[Address(RVA = "0x5414D40", Offset = "0x5413940", VA = "0x185414D40")]
		public static ObscuredVector3Int.RawEncryptedVector3Int Encrypt(int x, int y, int z, int key)
		{
			return default(ObscuredVector3Int.RawEncryptedVector3Int);
		}

		// Token: 0x0600303B RID: 12347 RVA: 0x000150D8 File Offset: 0x000132D8
		[Token(Token = "0x600303B")]
		[Address(RVA = "0x54148C0", Offset = "0x54134C0", VA = "0x1854148C0")]
		public static Vector3Int Decrypt(ObscuredVector3Int.RawEncryptedVector3Int value)
		{
			return default(Vector3Int);
		}

		// Token: 0x0600303C RID: 12348 RVA: 0x000150F0 File Offset: 0x000132F0
		[Token(Token = "0x600303C")]
		[Address(RVA = "0x54147F0", Offset = "0x54133F0", VA = "0x1854147F0")]
		public static Vector3Int Decrypt(ObscuredVector3Int.RawEncryptedVector3Int value, int key)
		{
			return default(Vector3Int);
		}

		// Token: 0x0600303D RID: 12349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600303D")]
		[Address(RVA = "0x54146D0", Offset = "0x54132D0", VA = "0x1854146D0")]
		public void ApplyNewCryptoKey()
		{
		}

		// Token: 0x0600303E RID: 12350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600303E")]
		[Address(RVA = "0x5415410", Offset = "0x5414010", VA = "0x185415410")]
		public void RandomizeCryptoKey()
		{
		}

		// Token: 0x0600303F RID: 12351 RVA: 0x00015108 File Offset: 0x00013308
		[Token(Token = "0x600303F")]
		[Address(RVA = "0x5414FB0", Offset = "0x5413BB0", VA = "0x185414FB0")]
		public ObscuredVector3Int.RawEncryptedVector3Int GetEncrypted()
		{
			return default(ObscuredVector3Int.RawEncryptedVector3Int);
		}

		// Token: 0x06003040 RID: 12352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003040")]
		[Address(RVA = "0x5415520", Offset = "0x5414120", VA = "0x185415520")]
		public void SetEncrypted(ObscuredVector3Int.RawEncryptedVector3Int encrypted)
		{
		}

		// Token: 0x06003041 RID: 12353 RVA: 0x00015120 File Offset: 0x00013320
		[Token(Token = "0x6003041")]
		[Address(RVA = "0x5414F40", Offset = "0x5413B40", VA = "0x185414F40")]
		public Vector3Int GetDecrypted()
		{
			return default(Vector3Int);
		}

		// Token: 0x06003042 RID: 12354 RVA: 0x00015138 File Offset: 0x00013338
		[Token(Token = "0x6003042")]
		[Address(RVA = "0x5415170", Offset = "0x5413D70", VA = "0x185415170")]
		private Vector3Int InternalDecrypt()
		{
			return default(Vector3Int);
		}

		// Token: 0x06003043 RID: 12355 RVA: 0x00015150 File Offset: 0x00013350
		[Token(Token = "0x6003043")]
		[Address(RVA = "0x54150E0", Offset = "0x5413CE0", VA = "0x1854150E0")]
		private int InternalDecryptField(int encrypted)
		{
			return 0;
		}

		// Token: 0x06003044 RID: 12356 RVA: 0x00015168 File Offset: 0x00013368
		[Token(Token = "0x6003044")]
		[Address(RVA = "0x5415380", Offset = "0x5413F80", VA = "0x185415380")]
		private int InternalEncryptField(int encrypted)
		{
			return 0;
		}

		// Token: 0x06003045 RID: 12357 RVA: 0x00015180 File Offset: 0x00013380
		[Token(Token = "0x6003045")]
		[Address(RVA = "0x54167C0", Offset = "0x54153C0", VA = "0x1854167C0")]
		public static implicit operator ObscuredVector3Int(Vector3Int value)
		{
			return default(ObscuredVector3Int);
		}

		// Token: 0x06003046 RID: 12358 RVA: 0x00015198 File Offset: 0x00013398
		[Token(Token = "0x6003046")]
		[Address(RVA = "0x5416800", Offset = "0x5415400", VA = "0x185416800")]
		public static implicit operator Vector3Int(ObscuredVector3Int value)
		{
			return default(Vector3Int);
		}

		// Token: 0x06003047 RID: 12359 RVA: 0x000151B0 File Offset: 0x000133B0
		[Token(Token = "0x6003047")]
		[Address(RVA = "0x5416710", Offset = "0x5415310", VA = "0x185416710")]
		public static implicit operator Vector3(ObscuredVector3Int value)
		{
			return default(Vector3);
		}

		// Token: 0x06003048 RID: 12360 RVA: 0x000151C8 File Offset: 0x000133C8
		[Token(Token = "0x6003048")]
		[Address(RVA = "0x54163E0", Offset = "0x5414FE0", VA = "0x1854163E0")]
		public static ObscuredVector3Int operator +(ObscuredVector3Int a, ObscuredVector3Int b)
		{
			return default(ObscuredVector3Int);
		}

		// Token: 0x06003049 RID: 12361 RVA: 0x000151E0 File Offset: 0x000133E0
		[Token(Token = "0x6003049")]
		[Address(RVA = "0x54162D0", Offset = "0x5414ED0", VA = "0x1854162D0")]
		public static ObscuredVector3Int operator +(Vector3Int a, ObscuredVector3Int b)
		{
			return default(ObscuredVector3Int);
		}

		// Token: 0x0600304A RID: 12362 RVA: 0x000151F8 File Offset: 0x000133F8
		[Token(Token = "0x600304A")]
		[Address(RVA = "0x54161D0", Offset = "0x5414DD0", VA = "0x1854161D0")]
		public static ObscuredVector3Int operator +(ObscuredVector3Int a, Vector3Int b)
		{
			return default(ObscuredVector3Int);
		}

		// Token: 0x0600304B RID: 12363 RVA: 0x00015210 File Offset: 0x00013410
		[Token(Token = "0x600304B")]
		[Address(RVA = "0x5416C80", Offset = "0x5415880", VA = "0x185416C80")]
		public static ObscuredVector3Int operator -(ObscuredVector3Int a, ObscuredVector3Int b)
		{
			return default(ObscuredVector3Int);
		}

		// Token: 0x0600304C RID: 12364 RVA: 0x00015228 File Offset: 0x00013428
		[Token(Token = "0x600304C")]
		[Address(RVA = "0x5416DA0", Offset = "0x54159A0", VA = "0x185416DA0")]
		public static ObscuredVector3Int operator -(Vector3Int a, ObscuredVector3Int b)
		{
			return default(ObscuredVector3Int);
		}

		// Token: 0x0600304D RID: 12365 RVA: 0x00015240 File Offset: 0x00013440
		[Token(Token = "0x600304D")]
		[Address(RVA = "0x5416B80", Offset = "0x5415780", VA = "0x185416B80")]
		public static ObscuredVector3Int operator -(ObscuredVector3Int a, Vector3Int b)
		{
			return default(ObscuredVector3Int);
		}

		// Token: 0x0600304E RID: 12366 RVA: 0x00015258 File Offset: 0x00013458
		[Token(Token = "0x600304E")]
		[Address(RVA = "0x5416A90", Offset = "0x5415690", VA = "0x185416A90")]
		public static ObscuredVector3Int operator *(ObscuredVector3Int a, int d)
		{
			return default(ObscuredVector3Int);
		}

		// Token: 0x0600304F RID: 12367 RVA: 0x00015270 File Offset: 0x00013470
		[Token(Token = "0x600304F")]
		[Address(RVA = "0x5416500", Offset = "0x5415100", VA = "0x185416500")]
		public static bool operator ==(ObscuredVector3Int lhs, ObscuredVector3Int rhs)
		{
			return default(bool);
		}

		// Token: 0x06003050 RID: 12368 RVA: 0x00015288 File Offset: 0x00013488
		[Token(Token = "0x6003050")]
		[Address(RVA = "0x54165C0", Offset = "0x54151C0", VA = "0x1854165C0")]
		public static bool operator ==(Vector3Int lhs, ObscuredVector3Int rhs)
		{
			return default(bool);
		}

		// Token: 0x06003051 RID: 12369 RVA: 0x000152A0 File Offset: 0x000134A0
		[Token(Token = "0x6003051")]
		[Address(RVA = "0x5416670", Offset = "0x5415270", VA = "0x185416670")]
		public static bool operator ==(ObscuredVector3Int lhs, Vector3Int rhs)
		{
			return default(bool);
		}

		// Token: 0x06003052 RID: 12370 RVA: 0x000152B8 File Offset: 0x000134B8
		[Token(Token = "0x6003052")]
		[Address(RVA = "0x54169D0", Offset = "0x54155D0", VA = "0x1854169D0")]
		public static bool operator !=(ObscuredVector3Int lhs, ObscuredVector3Int rhs)
		{
			return default(bool);
		}

		// Token: 0x06003053 RID: 12371 RVA: 0x000152D0 File Offset: 0x000134D0
		[Token(Token = "0x6003053")]
		[Address(RVA = "0x5416920", Offset = "0x5415520", VA = "0x185416920")]
		public static bool operator !=(Vector3Int lhs, ObscuredVector3Int rhs)
		{
			return default(bool);
		}

		// Token: 0x06003054 RID: 12372 RVA: 0x000152E8 File Offset: 0x000134E8
		[Token(Token = "0x6003054")]
		[Address(RVA = "0x5416870", Offset = "0x5415470", VA = "0x185416870")]
		public static bool operator !=(ObscuredVector3Int lhs, Vector3Int rhs)
		{
			return default(bool);
		}

		// Token: 0x06003055 RID: 12373 RVA: 0x00015300 File Offset: 0x00013500
		[Token(Token = "0x6003055")]
		[Address(RVA = "0x5414E30", Offset = "0x5413A30", VA = "0x185414E30", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06003056 RID: 12374 RVA: 0x00015318 File Offset: 0x00013518
		[Token(Token = "0x6003056")]
		[Address(RVA = "0x5415020", Offset = "0x5413C20", VA = "0x185415020", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06003057 RID: 12375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003057")]
		[Address(RVA = "0x5415890", Offset = "0x5414490", VA = "0x185415890", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003058 RID: 12376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003058")]
		[Address(RVA = "0x5415810", Offset = "0x5414410", VA = "0x185415810")]
		public string ToString(string format)
		{
			return null;
		}

		// Token: 0x04001A6A RID: 6762
		[Token(Token = "0x4001A6A")]
		[FieldOffset(Offset = "0x0")]
		private static int cryptoKey;

		// Token: 0x04001A6B RID: 6763
		[Token(Token = "0x4001A6B")]
		[FieldOffset(Offset = "0x4")]
		private static readonly Vector3Int zero;

		// Token: 0x04001A6C RID: 6764
		[Token(Token = "0x4001A6C")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private int currentCryptoKey;

		// Token: 0x04001A6D RID: 6765
		[Token(Token = "0x4001A6D")]
		[FieldOffset(Offset = "0x4")]
		[SerializeField]
		private ObscuredVector3Int.RawEncryptedVector3Int hiddenValue;

		// Token: 0x04001A6E RID: 6766
		[Token(Token = "0x4001A6E")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private bool inited;

		// Token: 0x04001A6F RID: 6767
		[Token(Token = "0x4001A6F")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Vector3Int fakeValue;

		// Token: 0x04001A70 RID: 6768
		[Token(Token = "0x4001A70")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool fakeValueActive;

		// Token: 0x02000587 RID: 1415
		[Token(Token = "0x2000587")]
		[Serializable]
		public struct RawEncryptedVector3Int
		{
			// Token: 0x04001A71 RID: 6769
			[Token(Token = "0x4001A71")]
			[FieldOffset(Offset = "0x0")]
			public int x;

			// Token: 0x04001A72 RID: 6770
			[Token(Token = "0x4001A72")]
			[FieldOffset(Offset = "0x4")]
			public int y;

			// Token: 0x04001A73 RID: 6771
			[Token(Token = "0x4001A73")]
			[FieldOffset(Offset = "0x8")]
			public int z;
		}
	}
}
