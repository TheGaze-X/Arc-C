using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.DataStream
{
	// Token: 0x020016C0 RID: 5824
	[Token(Token = "0x20016C0")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class DataStreamUtil
	{
		// Token: 0x06009366 RID: 37734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009366")]
		public static void WriteByteEnum<TEnum>(this IStreamWriter to, TEnum v) where TEnum : struct
		{
		}

		// Token: 0x06009367 RID: 37735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009367")]
		public static void Write<T>(this IStreamWriter to, T data) where T : IStreamSerialize
		{
		}

		// Token: 0x06009368 RID: 37736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009368")]
		public static void WriteList2<T>(this IStreamWriter to, IList<T> list) where T : IStreamSerialize
		{
		}

		// Token: 0x06009369 RID: 37737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009369")]
		[Address(RVA = "0x2B33030", Offset = "0x2B31C30", VA = "0x182B33030")]
		public static void WriteList2(this IStreamWriter to, IList<int> list)
		{
		}

		// Token: 0x0600936A RID: 37738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600936A")]
		[Address(RVA = "0x2B32BB0", Offset = "0x2B317B0", VA = "0x182B32BB0")]
		public static void WriteList2(this IStreamWriter to, IList<string> list)
		{
		}

		// Token: 0x0600936B RID: 37739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600936B")]
		[Address(RVA = "0x2B32DF0", Offset = "0x2B319F0", VA = "0x182B32DF0")]
		public static void WriteList2(this IStreamWriter to, IList<byte> list)
		{
		}

		// Token: 0x0600936C RID: 37740 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600936C")]
		public static TEnum ReadStr2Enum<TEnum>(this IStreamReader from, TEnum defaultValue) where TEnum : struct
		{
			return null;
		}

		// Token: 0x0600936D RID: 37741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600936D")]
		public static TEnum ReadByteEnum<TEnum>(this IStreamReader from, TEnum ev) where TEnum : struct
		{
			return null;
		}

		// Token: 0x0600936E RID: 37742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600936E")]
		public static List<TEnum> ReadByteEnumList2<TEnum>(this IStreamReader from, List<TEnum> list) where TEnum : struct
		{
			return null;
		}

		// Token: 0x0600936F RID: 37743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600936F")]
		public static T Read<T>(this IStreamReader from, T data) where T : IStreamDeserialize
		{
			return null;
		}

		// Token: 0x06009370 RID: 37744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009370")]
		public static List<T> ReadList2<T>(this IStreamReader from, List<T> list, [Optional] Func<T> creator) where T : IStreamDeserialize, new()
		{
			return null;
		}

		// Token: 0x06009371 RID: 37745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009371")]
		[Address(RVA = "0x2B32790", Offset = "0x2B31390", VA = "0x182B32790")]
		public static List<int> ReadList2(this IStreamReader from, List<int> list)
		{
			return null;
		}

		// Token: 0x06009372 RID: 37746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009372")]
		[Address(RVA = "0x2B325A0", Offset = "0x2B311A0", VA = "0x182B325A0")]
		public static List<string> ReadList2(this IStreamReader from, List<string> list)
		{
			return null;
		}

		// Token: 0x06009373 RID: 37747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009373")]
		[Address(RVA = "0x2B329C0", Offset = "0x2B315C0", VA = "0x182B329C0")]
		public static List<string> ReadStr2List2(IStreamReader from, List<string> list)
		{
			return null;
		}

		// Token: 0x06009374 RID: 37748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009374")]
		[Address(RVA = "0x2B32370", Offset = "0x2B30F70", VA = "0x182B32370")]
		public static List<int> ReadInt32List2(IStreamReader from, List<int> list)
		{
			return null;
		}

		// Token: 0x06009375 RID: 37749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009375")]
		public static Dictionary<string, T> ReadStr2Dic2<T>(this IStreamReader from, Dictionary<string, T> dict) where T : IStreamDeserialize, new()
		{
			return null;
		}

		// Token: 0x06009376 RID: 37750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009376")]
		public static ListDict<string, T> ReadStr2Dic2<T>(IStreamReader from, ListDict<string, T> dict) where T : IStreamDeserialize, new()
		{
			return null;
		}

		// Token: 0x06009377 RID: 37751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009377")]
		public static T ReadNullable<T>(this IStreamReader from, [Optional] Func<T> creator) where T : IStreamDeserialize, new()
		{
			return null;
		}

		// Token: 0x06009378 RID: 37752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009378")]
		[Address(RVA = "0x2B32130", Offset = "0x2B30D30", VA = "0x182B32130")]
		public static List<int> ReadByteList2(this IStreamReader from, List<int> list)
		{
			return null;
		}

		// Token: 0x06009379 RID: 37753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009379")]
		public static T ReadClass<T>(this IStreamReader from, T data) where T : IStreamDeserialize, new()
		{
			return null;
		}

		// Token: 0x04008920 RID: 35104
		[Token(Token = "0x4008920")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_WriteByteEnum;

		// Token: 0x04008921 RID: 35105
		[Token(Token = "0x4008921")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Write;

		// Token: 0x04008922 RID: 35106
		[Token(Token = "0x4008922")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_WriteList2;

		// Token: 0x04008923 RID: 35107
		[Token(Token = "0x4008923")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix1_WriteList2;

		// Token: 0x04008924 RID: 35108
		[Token(Token = "0x4008924")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix2_WriteList2;

		// Token: 0x04008925 RID: 35109
		[Token(Token = "0x4008925")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix3_WriteList2;

		// Token: 0x04008926 RID: 35110
		[Token(Token = "0x4008926")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ReadStr2Enum;

		// Token: 0x04008927 RID: 35111
		[Token(Token = "0x4008927")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_ReadByteEnum;

		// Token: 0x04008928 RID: 35112
		[Token(Token = "0x4008928")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_ReadByteEnumList2;

		// Token: 0x04008929 RID: 35113
		[Token(Token = "0x4008929")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_Read;

		// Token: 0x0400892A RID: 35114
		[Token(Token = "0x400892A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_ReadList2;

		// Token: 0x0400892B RID: 35115
		[Token(Token = "0x400892B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix1_ReadList2;

		// Token: 0x0400892C RID: 35116
		[Token(Token = "0x400892C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix2_ReadList2;

		// Token: 0x0400892D RID: 35117
		[Token(Token = "0x400892D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_ReadStr2List2;

		// Token: 0x0400892E RID: 35118
		[Token(Token = "0x400892E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_ReadInt32List2;

		// Token: 0x0400892F RID: 35119
		[Token(Token = "0x400892F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_ReadStr2Dic2;

		// Token: 0x04008930 RID: 35120
		[Token(Token = "0x4008930")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix1_ReadStr2Dic2;

		// Token: 0x04008931 RID: 35121
		[Token(Token = "0x4008931")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_ReadNullable;

		// Token: 0x04008932 RID: 35122
		[Token(Token = "0x4008932")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_ReadByteList2;

		// Token: 0x04008933 RID: 35123
		[Token(Token = "0x4008933")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_ReadClass;
	}
}
