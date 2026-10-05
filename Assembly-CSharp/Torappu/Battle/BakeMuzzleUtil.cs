using System;
using Il2CppDummyDll;
using Torappu.DB;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002171 RID: 8561
	[Token(Token = "0x2002171")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class BakeMuzzleUtil
	{
		// Token: 0x17001954 RID: 6484
		// (get) Token: 0x0600D2DA RID: 53978 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001954")]
		private static IConverter decrypter
		{
			[Token(Token = "0x600D2DA")]
			[Address(RVA = "0x3532CD0", Offset = "0x35318D0", VA = "0x183532CD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001955 RID: 6485
		// (get) Token: 0x0600D2DB RID: 53979 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001955")]
		public static IConverter plainTextConverter
		{
			[Token(Token = "0x600D2DB")]
			[Address(RVA = "0x3532D70", Offset = "0x3531970", VA = "0x183532D70")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600D2DC RID: 53980 RVA: 0x0004BFA8 File Offset: 0x0004A1A8
		[Token(Token = "0x600D2DC")]
		[Address(RVA = "0x3532630", Offset = "0x3531230", VA = "0x183532630")]
		public static bool TryLoadBakeMuzzleData(string dataPath, out BakedSpineData bakedSpineData)
		{
			return default(bool);
		}

		// Token: 0x0600D2DD RID: 53981 RVA: 0x0004BFC0 File Offset: 0x0004A1C0
		[Token(Token = "0x600D2DD")]
		[Address(RVA = "0x3532220", Offset = "0x3530E20", VA = "0x183532220")]
		public static Vector3 FloatArrayToVector3(float[] arr)
		{
			return default(Vector3);
		}

		// Token: 0x0600D2DE RID: 53982 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D2DE")]
		[Address(RVA = "0x3532870", Offset = "0x3531470", VA = "0x183532870")]
		public static float[] Vector3ToFloatArray(Vector3 vec)
		{
			return null;
		}

		// Token: 0x0600D2DF RID: 53983 RVA: 0x0004BFD8 File Offset: 0x0004A1D8
		[Token(Token = "0x600D2DF")]
		[Address(RVA = "0x3532120", Offset = "0x3530D20", VA = "0x183532120")]
		public static Quaternion FloatArrayToQuaternion(float[] arr)
		{
			return default(Quaternion);
		}

		// Token: 0x0600D2E0 RID: 53984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D2E0")]
		[Address(RVA = "0x35323B0", Offset = "0x3530FB0", VA = "0x1835323B0")]
		public static float[] QuaternionToFloatArray(Quaternion quat)
		{
			return null;
		}

		// Token: 0x0600D2E1 RID: 53985 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D2E1")]
		[Address(RVA = "0x3532930", Offset = "0x3531530", VA = "0x183532930")]
		private static BakedSpineData _ParseBakedSpineData(TextAsset textAsset)
		{
			return null;
		}

		// Token: 0x0600D2E2 RID: 53986 RVA: 0x0004BFF0 File Offset: 0x0004A1F0
		[Token(Token = "0x600D2E2")]
		[Address(RVA = "0x3532B80", Offset = "0x3531780", VA = "0x183532B80")]
		private static bool _TryLoadBakedSpineDataAsset(string path, out TextAsset bakedDataAsset)
		{
			return default(bool);
		}

		// Token: 0x0600D2E3 RID: 53987 RVA: 0x0004C008 File Offset: 0x0004A208
		[Token(Token = "0x600D2E3")]
		[Address(RVA = "0x3532470", Offset = "0x3531070", VA = "0x183532470")]
		public static Quaternion SafeLerpQuaternion(Quaternion quat1, Quaternion quat2, float ratio)
		{
			return default(Quaternion);
		}

		// Token: 0x0600D2E4 RID: 53988 RVA: 0x0004C020 File Offset: 0x0004A220
		[Token(Token = "0x600D2E4")]
		[Address(RVA = "0x3532320", Offset = "0x3530F20", VA = "0x183532320")]
		public static bool IsDeviceEnableBakeMuzzle()
		{
			return default(bool);
		}

		// Token: 0x0400E1DD RID: 57821
		[Token(Token = "0x400E1DD")]
		[FieldOffset(Offset = "0x0")]
		private static IConverter m_decrypter;

		// Token: 0x0400E1DE RID: 57822
		[Token(Token = "0x400E1DE")]
		[FieldOffset(Offset = "0x8")]
		private static IConverter m_plainTextConverter;

		// Token: 0x0400E1DF RID: 57823
		[Token(Token = "0x400E1DF")]
		public const ConverterFactory.ConverterType BAKE_MUZZLE_CONVERTER_TYPE = ConverterFactory.ConverterType.FLAT_BUFFER;

		// Token: 0x0400E1E0 RID: 57824
		[Token(Token = "0x400E1E0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_decrypter;

		// Token: 0x0400E1E1 RID: 57825
		[Token(Token = "0x400E1E1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_plainTextConverter;

		// Token: 0x0400E1E2 RID: 57826
		[Token(Token = "0x400E1E2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_TryLoadBakeMuzzleData;

		// Token: 0x0400E1E3 RID: 57827
		[Token(Token = "0x400E1E3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_FloatArrayToVector3;

		// Token: 0x0400E1E4 RID: 57828
		[Token(Token = "0x400E1E4")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Vector3ToFloatArray;

		// Token: 0x0400E1E5 RID: 57829
		[Token(Token = "0x400E1E5")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_FloatArrayToQuaternion;

		// Token: 0x0400E1E6 RID: 57830
		[Token(Token = "0x400E1E6")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_QuaternionToFloatArray;

		// Token: 0x0400E1E7 RID: 57831
		[Token(Token = "0x400E1E7")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__ParseBakedSpineData;

		// Token: 0x0400E1E8 RID: 57832
		[Token(Token = "0x400E1E8")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__TryLoadBakedSpineDataAsset;

		// Token: 0x0400E1E9 RID: 57833
		[Token(Token = "0x400E1E9")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_SafeLerpQuaternion;

		// Token: 0x0400E1EA RID: 57834
		[Token(Token = "0x400E1EA")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_IsDeviceEnableBakeMuzzle;
	}
}
