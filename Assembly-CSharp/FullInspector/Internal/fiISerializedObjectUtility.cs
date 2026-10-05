using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace FullInspector.Internal
{
	// Token: 0x02007C87 RID: 31879
	[Token(Token = "0x2007C87")]
	public static class fiISerializedObjectUtility
	{
		// Token: 0x0602C88E RID: 182414 RVA: 0x000E09A0 File Offset: 0x000DEBA0
		[Token(Token = "0x602C88E")]
		[Address(RVA = "0x286A7C0", Offset = "0x28693C0", VA = "0x18286A7C0")]
		private static bool SaveStateForProperty(ISerializedObject obj, InspectedProperty property, BaseSerializer serializer, ISerializationOperator serializationOperator, out string serializedValue, ref bool success)
		{
			return default(bool);
		}

		// Token: 0x0602C88F RID: 182415 RVA: 0x000E09B8 File Offset: 0x000DEBB8
		[Token(Token = "0x602C88F")]
		public static bool SaveState<TSerializer>(ISerializedObject obj) where TSerializer : BaseSerializer
		{
			return default(bool);
		}

		// Token: 0x0602C890 RID: 182416 RVA: 0x000E09D0 File Offset: 0x000DEBD0
		[Token(Token = "0x602C890")]
		[Address(RVA = "0x286A360", Offset = "0x2868F60", VA = "0x18286A360")]
		private static bool AreListsDifferent(IList<string> a, IList<string> b)
		{
			return default(bool);
		}

		// Token: 0x0602C891 RID: 182417 RVA: 0x000E09E8 File Offset: 0x000DEBE8
		[Token(Token = "0x602C891")]
		[Address(RVA = "0x286A470", Offset = "0x2869070", VA = "0x18286A470")]
		private static bool AreListsDifferent(IList<UnityEngine.Object> a, IList<UnityEngine.Object> b)
		{
			return default(bool);
		}

		// Token: 0x0602C892 RID: 182418 RVA: 0x000E0A00 File Offset: 0x000DEC00
		[Token(Token = "0x602C892")]
		public static bool RestoreState<TSerializer>(ISerializedObject obj) where TSerializer : BaseSerializer
		{
			return default(bool);
		}

		// Token: 0x0602C893 RID: 182419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C893")]
		[Address(RVA = "0x286A570", Offset = "0x2869170", VA = "0x18286A570")]
		private static void InstantiateReferences(object obj, InspectedType metadata)
		{
		}
	}
}
