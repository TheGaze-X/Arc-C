using System;
using Il2CppDummyDll;
using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	// Token: 0x02000584 RID: 1412
	[Token(Token = "0x2000584")]
	[Serializable]
	public struct ObscuredVector3
	{
		// Token: 0x06002FFD RID: 12285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FFD")]
		[Address(RVA = "0x5418360", Offset = "0x5416F60", VA = "0x185418360")]
		private ObscuredVector3(Vector3 value)
		{
		}

		// Token: 0x06002FFE RID: 12286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FFE")]
		[Address(RVA = "0x54184D0", Offset = "0x54170D0", VA = "0x1854184D0")]
		public ObscuredVector3(float x, float y, float z)
		{
		}

		// Token: 0x170006F1 RID: 1777
		// (get) Token: 0x06002FFF RID: 12287 RVA: 0x00014CE8 File Offset: 0x00012EE8
		// (set) Token: 0x06003000 RID: 12288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006F1")]
		public float x
		{
			[Token(Token = "0x6002FFF")]
			[Address(RVA = "0x54186F0", Offset = "0x54172F0", VA = "0x1854186F0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003000")]
			[Address(RVA = "0x5419CA0", Offset = "0x54188A0", VA = "0x185419CA0")]
			set
			{
			}
		}

		// Token: 0x170006F2 RID: 1778
		// (get) Token: 0x06003001 RID: 12289 RVA: 0x00014D00 File Offset: 0x00012F00
		// (set) Token: 0x06003002 RID: 12290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006F2")]
		public float y
		{
			[Token(Token = "0x6003001")]
			[Address(RVA = "0x5418860", Offset = "0x5417460", VA = "0x185418860")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003002")]
			[Address(RVA = "0x5419D70", Offset = "0x5418970", VA = "0x185419D70")]
			set
			{
			}
		}

		// Token: 0x170006F3 RID: 1779
		// (get) Token: 0x06003003 RID: 12291 RVA: 0x00014D18 File Offset: 0x00012F18
		// (set) Token: 0x06003004 RID: 12292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006F3")]
		public float z
		{
			[Token(Token = "0x6003003")]
			[Address(RVA = "0x54189D0", Offset = "0x54175D0", VA = "0x1854189D0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003004")]
			[Address(RVA = "0x5419E40", Offset = "0x5418A40", VA = "0x185419E40")]
			set
			{
			}
		}

		// Token: 0x170006F4 RID: 1780
		[Token(Token = "0x170006F4")]
		public float this[int index]
		{
			[Token(Token = "0x6003005")]
			[Address(RVA = "0x54185E0", Offset = "0x54171E0", VA = "0x1854185E0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003006")]
			[Address(RVA = "0x5419B70", Offset = "0x5418770", VA = "0x185419B70")]
			set
			{
			}
		}

		// Token: 0x06003007 RID: 12295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003007")]
		[Address(RVA = "0x5418180", Offset = "0x5416D80", VA = "0x185418180")]
		public static void SetNewCryptoKey(int newKey)
		{
		}

		// Token: 0x06003008 RID: 12296 RVA: 0x00014D48 File Offset: 0x00012F48
		[Token(Token = "0x6003008")]
		[Address(RVA = "0x54176C0", Offset = "0x54162C0", VA = "0x1854176C0")]
		public static ObscuredVector3.RawEncryptedVector3 Encrypt(Vector3 value)
		{
			return default(ObscuredVector3.RawEncryptedVector3);
		}

		// Token: 0x06003009 RID: 12297 RVA: 0x00014D60 File Offset: 0x00012F60
		[Token(Token = "0x6003009")]
		[Address(RVA = "0x5417790", Offset = "0x5416390", VA = "0x185417790")]
		public static ObscuredVector3.RawEncryptedVector3 Encrypt(Vector3 value, int key)
		{
			return default(ObscuredVector3.RawEncryptedVector3);
		}

		// Token: 0x0600300A RID: 12298 RVA: 0x00014D78 File Offset: 0x00012F78
		[Token(Token = "0x600300A")]
		[Address(RVA = "0x5417820", Offset = "0x5416420", VA = "0x185417820")]
		public static ObscuredVector3.RawEncryptedVector3 Encrypt(float x, float y, float z, int key)
		{
			return default(ObscuredVector3.RawEncryptedVector3);
		}

		// Token: 0x0600300B RID: 12299 RVA: 0x00014D90 File Offset: 0x00012F90
		[Token(Token = "0x600300B")]
		[Address(RVA = "0x5417460", Offset = "0x5416060", VA = "0x185417460")]
		public static Vector3 Decrypt(ObscuredVector3.RawEncryptedVector3 value)
		{
			return default(Vector3);
		}

		// Token: 0x0600300C RID: 12300 RVA: 0x00014DA8 File Offset: 0x00012FA8
		[Token(Token = "0x600300C")]
		[Address(RVA = "0x54175B0", Offset = "0x54161B0", VA = "0x1854175B0")]
		public static Vector3 Decrypt(ObscuredVector3.RawEncryptedVector3 value, int key)
		{
			return default(Vector3);
		}

		// Token: 0x0600300D RID: 12301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600300D")]
		[Address(RVA = "0x5417220", Offset = "0x5415E20", VA = "0x185417220")]
		public void ApplyNewCryptoKey()
		{
		}

		// Token: 0x0600300E RID: 12302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600300E")]
		[Address(RVA = "0x5417FB0", Offset = "0x5416BB0", VA = "0x185417FB0")]
		public void RandomizeCryptoKey()
		{
		}

		// Token: 0x0600300F RID: 12303 RVA: 0x00014DC0 File Offset: 0x00012FC0
		[Token(Token = "0x600300F")]
		[Address(RVA = "0x5417AE0", Offset = "0x54166E0", VA = "0x185417AE0")]
		public ObscuredVector3.RawEncryptedVector3 GetEncrypted()
		{
			return default(ObscuredVector3.RawEncryptedVector3);
		}

		// Token: 0x06003010 RID: 12304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003010")]
		[Address(RVA = "0x54180C0", Offset = "0x5416CC0", VA = "0x1854180C0")]
		public void SetEncrypted(ObscuredVector3.RawEncryptedVector3 encrypted)
		{
		}

		// Token: 0x06003011 RID: 12305 RVA: 0x00014DD8 File Offset: 0x00012FD8
		[Token(Token = "0x6003011")]
		[Address(RVA = "0x5417A70", Offset = "0x5416670", VA = "0x185417A70")]
		public Vector3 GetDecrypted()
		{
			return default(Vector3);
		}

		// Token: 0x06003012 RID: 12306 RVA: 0x00014DF0 File Offset: 0x00012FF0
		[Token(Token = "0x6003012")]
		[Address(RVA = "0x5417C90", Offset = "0x5416890", VA = "0x185417C90")]
		private Vector3 InternalDecrypt()
		{
			return default(Vector3);
		}

		// Token: 0x06003013 RID: 12307 RVA: 0x00014E08 File Offset: 0x00013008
		[Token(Token = "0x6003013")]
		[Address(RVA = "0x5417340", Offset = "0x5415F40", VA = "0x185417340")]
		private bool CompareVectorsWithTolerance(Vector3 vector1, Vector3 vector2)
		{
			return default(bool);
		}

		// Token: 0x06003014 RID: 12308 RVA: 0x00014E20 File Offset: 0x00013020
		[Token(Token = "0x6003014")]
		[Address(RVA = "0x5417BF0", Offset = "0x54167F0", VA = "0x185417BF0")]
		private float InternalDecryptField(int encrypted)
		{
			return 0f;
		}

		// Token: 0x06003015 RID: 12309 RVA: 0x00014E38 File Offset: 0x00013038
		[Token(Token = "0x6003015")]
		[Address(RVA = "0x5417F10", Offset = "0x5416B10", VA = "0x185417F10")]
		private int InternalEncryptField(float encrypted)
		{
			return 0;
		}

		// Token: 0x06003016 RID: 12310 RVA: 0x00014E50 File Offset: 0x00013050
		[Token(Token = "0x6003016")]
		[Address(RVA = "0x5419280", Offset = "0x5417E80", VA = "0x185419280")]
		public static implicit operator ObscuredVector3(Vector3 value)
		{
			return default(ObscuredVector3);
		}

		// Token: 0x06003017 RID: 12311 RVA: 0x00014E68 File Offset: 0x00013068
		[Token(Token = "0x6003017")]
		[Address(RVA = "0x5419210", Offset = "0x5417E10", VA = "0x185419210")]
		public static implicit operator Vector3(ObscuredVector3 value)
		{
			return default(Vector3);
		}

		// Token: 0x06003018 RID: 12312 RVA: 0x00014E80 File Offset: 0x00013080
		[Token(Token = "0x6003018")]
		[Address(RVA = "0x5418C50", Offset = "0x5417850", VA = "0x185418C50")]
		public static ObscuredVector3 operator +(ObscuredVector3 a, ObscuredVector3 b)
		{
			return default(ObscuredVector3);
		}

		// Token: 0x06003019 RID: 12313 RVA: 0x00014E98 File Offset: 0x00013098
		[Token(Token = "0x6003019")]
		[Address(RVA = "0x5418B40", Offset = "0x5417740", VA = "0x185418B40")]
		public static ObscuredVector3 operator +(Vector3 a, ObscuredVector3 b)
		{
			return default(ObscuredVector3);
		}

		// Token: 0x0600301A RID: 12314 RVA: 0x00014EB0 File Offset: 0x000130B0
		[Token(Token = "0x600301A")]
		[Address(RVA = "0x5418D80", Offset = "0x5417980", VA = "0x185418D80")]
		public static ObscuredVector3 operator +(ObscuredVector3 a, Vector3 b)
		{
			return default(ObscuredVector3);
		}

		// Token: 0x0600301B RID: 12315 RVA: 0x00014EC8 File Offset: 0x000130C8
		[Token(Token = "0x600301B")]
		[Address(RVA = "0x5419950", Offset = "0x5418550", VA = "0x185419950")]
		public static ObscuredVector3 operator -(ObscuredVector3 a, ObscuredVector3 b)
		{
			return default(ObscuredVector3);
		}

		// Token: 0x0600301C RID: 12316 RVA: 0x00014EE0 File Offset: 0x000130E0
		[Token(Token = "0x600301C")]
		[Address(RVA = "0x5419720", Offset = "0x5418320", VA = "0x185419720")]
		public static ObscuredVector3 operator -(Vector3 a, ObscuredVector3 b)
		{
			return default(ObscuredVector3);
		}

		// Token: 0x0600301D RID: 12317 RVA: 0x00014EF8 File Offset: 0x000130F8
		[Token(Token = "0x600301D")]
		[Address(RVA = "0x5419830", Offset = "0x5418430", VA = "0x185419830")]
		public static ObscuredVector3 operator -(ObscuredVector3 a, Vector3 b)
		{
			return default(ObscuredVector3);
		}

		// Token: 0x0600301E RID: 12318 RVA: 0x00014F10 File Offset: 0x00013110
		[Token(Token = "0x600301E")]
		[Address(RVA = "0x5419A80", Offset = "0x5418680", VA = "0x185419A80")]
		public static ObscuredVector3 operator -(ObscuredVector3 a)
		{
			return default(ObscuredVector3);
		}

		// Token: 0x0600301F RID: 12319 RVA: 0x00014F28 File Offset: 0x00013128
		[Token(Token = "0x600301F")]
		[Address(RVA = "0x5419520", Offset = "0x5418120", VA = "0x185419520")]
		public static ObscuredVector3 operator *(ObscuredVector3 a, float d)
		{
			return default(ObscuredVector3);
		}

		// Token: 0x06003020 RID: 12320 RVA: 0x00014F40 File Offset: 0x00013140
		[Token(Token = "0x6003020")]
		[Address(RVA = "0x5419620", Offset = "0x5418220", VA = "0x185419620")]
		public static ObscuredVector3 operator *(float d, ObscuredVector3 a)
		{
			return default(ObscuredVector3);
		}

		// Token: 0x06003021 RID: 12321 RVA: 0x00014F58 File Offset: 0x00013158
		[Token(Token = "0x6003021")]
		[Address(RVA = "0x5418EA0", Offset = "0x5417AA0", VA = "0x185418EA0")]
		public static ObscuredVector3 operator /(ObscuredVector3 a, float d)
		{
			return default(ObscuredVector3);
		}

		// Token: 0x06003022 RID: 12322 RVA: 0x00014F70 File Offset: 0x00013170
		[Token(Token = "0x6003022")]
		[Address(RVA = "0x5418FA0", Offset = "0x5417BA0", VA = "0x185418FA0")]
		public static bool operator ==(ObscuredVector3 lhs, ObscuredVector3 rhs)
		{
			return default(bool);
		}

		// Token: 0x06003023 RID: 12323 RVA: 0x00014F88 File Offset: 0x00013188
		[Token(Token = "0x6003023")]
		[Address(RVA = "0x5419080", Offset = "0x5417C80", VA = "0x185419080")]
		public static bool operator ==(Vector3 lhs, ObscuredVector3 rhs)
		{
			return default(bool);
		}

		// Token: 0x06003024 RID: 12324 RVA: 0x00014FA0 File Offset: 0x000131A0
		[Token(Token = "0x6003024")]
		[Address(RVA = "0x5419140", Offset = "0x5417D40", VA = "0x185419140")]
		public static bool operator ==(ObscuredVector3 lhs, Vector3 rhs)
		{
			return default(bool);
		}

		// Token: 0x06003025 RID: 12325 RVA: 0x00014FB8 File Offset: 0x000131B8
		[Token(Token = "0x6003025")]
		[Address(RVA = "0x54192C0", Offset = "0x5417EC0", VA = "0x1854192C0")]
		public static bool operator !=(ObscuredVector3 lhs, ObscuredVector3 rhs)
		{
			return default(bool);
		}

		// Token: 0x06003026 RID: 12326 RVA: 0x00014FD0 File Offset: 0x000131D0
		[Token(Token = "0x6003026")]
		[Address(RVA = "0x5419460", Offset = "0x5418060", VA = "0x185419460")]
		public static bool operator !=(Vector3 lhs, ObscuredVector3 rhs)
		{
			return default(bool);
		}

		// Token: 0x06003027 RID: 12327 RVA: 0x00014FE8 File Offset: 0x000131E8
		[Token(Token = "0x6003027")]
		[Address(RVA = "0x54193A0", Offset = "0x5417FA0", VA = "0x1854193A0")]
		public static bool operator !=(ObscuredVector3 lhs, Vector3 rhs)
		{
			return default(bool);
		}

		// Token: 0x06003028 RID: 12328 RVA: 0x00015000 File Offset: 0x00013200
		[Token(Token = "0x6003028")]
		[Address(RVA = "0x5417960", Offset = "0x5416560", VA = "0x185417960", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06003029 RID: 12329 RVA: 0x00015018 File Offset: 0x00013218
		[Token(Token = "0x6003029")]
		[Address(RVA = "0x5417B50", Offset = "0x5416750", VA = "0x185417B50", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600302A RID: 12330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600302A")]
		[Address(RVA = "0x54181E0", Offset = "0x5416DE0", VA = "0x1854181E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600302B RID: 12331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600302B")]
		[Address(RVA = "0x5418250", Offset = "0x5416E50", VA = "0x185418250")]
		public string ToString(string format)
		{
			return null;
		}

		// Token: 0x04001A60 RID: 6752
		[Token(Token = "0x4001A60")]
		[FieldOffset(Offset = "0x0")]
		private static int cryptoKey;

		// Token: 0x04001A61 RID: 6753
		[Token(Token = "0x4001A61")]
		[FieldOffset(Offset = "0x4")]
		private static readonly Vector3 zero;

		// Token: 0x04001A62 RID: 6754
		[Token(Token = "0x4001A62")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private int currentCryptoKey;

		// Token: 0x04001A63 RID: 6755
		[Token(Token = "0x4001A63")]
		[FieldOffset(Offset = "0x4")]
		[SerializeField]
		private ObscuredVector3.RawEncryptedVector3 hiddenValue;

		// Token: 0x04001A64 RID: 6756
		[Token(Token = "0x4001A64")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private bool inited;

		// Token: 0x04001A65 RID: 6757
		[Token(Token = "0x4001A65")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Vector3 fakeValue;

		// Token: 0x04001A66 RID: 6758
		[Token(Token = "0x4001A66")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool fakeValueActive;

		// Token: 0x02000585 RID: 1413
		[Token(Token = "0x2000585")]
		[Serializable]
		public struct RawEncryptedVector3
		{
			// Token: 0x04001A67 RID: 6759
			[Token(Token = "0x4001A67")]
			[FieldOffset(Offset = "0x0")]
			public int x;

			// Token: 0x04001A68 RID: 6760
			[Token(Token = "0x4001A68")]
			[FieldOffset(Offset = "0x4")]
			public int y;

			// Token: 0x04001A69 RID: 6761
			[Token(Token = "0x4001A69")]
			[FieldOffset(Offset = "0x8")]
			public int z;
		}
	}
}
