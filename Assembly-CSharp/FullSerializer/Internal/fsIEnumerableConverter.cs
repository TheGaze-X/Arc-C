using System;
using System.Collections;
using System.Reflection;
using Il2CppDummyDll;

namespace FullSerializer.Internal
{
	// Token: 0x02007B8A RID: 31626
	[Token(Token = "0x2007B8A")]
	public class fsIEnumerableConverter : fsConverter
	{
		// Token: 0x0602C456 RID: 181334 RVA: 0x000DF128 File Offset: 0x000DD328
		[Token(Token = "0x602C456")]
		[Address(RVA = "0x2829670", Offset = "0x2828270", VA = "0x182829670", Slot = "9")]
		public override bool CanProcess(Type type)
		{
			return default(bool);
		}

		// Token: 0x0602C457 RID: 181335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C457")]
		[Address(RVA = "0x2829740", Offset = "0x2828340", VA = "0x182829740", Slot = "4")]
		public override object CreateInstance(fsData data, Type storageType)
		{
			return null;
		}

		// Token: 0x0602C458 RID: 181336 RVA: 0x000DF140 File Offset: 0x000DD340
		[Token(Token = "0x602C458")]
		[Address(RVA = "0x282A780", Offset = "0x2829380", VA = "0x18282A780", Slot = "7")]
		public override fsResult TrySerialize(object instance_, out fsData serialized, Type storageType)
		{
			return default(fsResult);
		}

		// Token: 0x0602C459 RID: 181337 RVA: 0x000DF158 File Offset: 0x000DD358
		[Token(Token = "0x602C459")]
		[Address(RVA = "0x2829CA0", Offset = "0x28288A0", VA = "0x182829CA0")]
		private bool IsStack(Type type)
		{
			return default(bool);
		}

		// Token: 0x0602C45A RID: 181338 RVA: 0x000DF170 File Offset: 0x000DD370
		[Token(Token = "0x602C45A")]
		[Address(RVA = "0x2829E60", Offset = "0x2828A60", VA = "0x182829E60", Slot = "8")]
		public override fsResult TryDeserialize(fsData data, ref object instance_, Type storageType)
		{
			return default(fsResult);
		}

		// Token: 0x0602C45B RID: 181339 RVA: 0x000DF188 File Offset: 0x000DD388
		[Token(Token = "0x602C45B")]
		[Address(RVA = "0x2829BF0", Offset = "0x28287F0", VA = "0x182829BF0")]
		private static int HintSize(IEnumerable collection)
		{
			return 0;
		}

		// Token: 0x0602C45C RID: 181340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C45C")]
		[Address(RVA = "0x2829A90", Offset = "0x2828690", VA = "0x182829A90")]
		private static Type GetElementType(Type objectType)
		{
			return null;
		}

		// Token: 0x0602C45D RID: 181341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C45D")]
		[Address(RVA = "0x2829DC0", Offset = "0x28289C0", VA = "0x182829DC0")]
		private static void TryClear(Type type, object instance)
		{
		}

		// Token: 0x0602C45E RID: 181342 RVA: 0x000DF1A0 File Offset: 0x000DD3A0
		[Token(Token = "0x602C45E")]
		[Address(RVA = "0x282A520", Offset = "0x2829120", VA = "0x18282A520")]
		private static int TryGetExistingSize(Type type, object instance)
		{
			return 0;
		}

		// Token: 0x0602C45F RID: 181343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C45F")]
		[Address(RVA = "0x28297C0", Offset = "0x28283C0", VA = "0x1828297C0")]
		private static MethodInfo GetAddMethod(Type type)
		{
			return null;
		}

		// Token: 0x0602C460 RID: 181344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C460")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public fsIEnumerableConverter()
		{
		}
	}
}
