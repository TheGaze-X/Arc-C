using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.LevelScript
{
	// Token: 0x02002872 RID: 10354
	[Token(Token = "0x2002872")]
	public class ParamParser : Singleton<ParamParser>
	{
		// Token: 0x060113B2 RID: 70578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60113B2")]
		[Address(RVA = "0x924350", Offset = "0x922F50", VA = "0x180924350")]
		private ParamParser()
		{
		}

		// Token: 0x060113B3 RID: 70579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60113B3")]
		[Address(RVA = "0x923E20", Offset = "0x922A20", VA = "0x180923E20")]
		public static Dictionary<Type, IParamParser> GetAllParser()
		{
			return null;
		}

		// Token: 0x060113B4 RID: 70580 RVA: 0x0006A2F0 File Offset: 0x000684F0
		[Token(Token = "0x60113B4")]
		[Address(RVA = "0x924270", Offset = "0x922E70", VA = "0x180924270")]
		public static bool TryGetRawParser(ParamRealType valueType, out IParamParser result)
		{
			return default(bool);
		}

		// Token: 0x060113B5 RID: 70581 RVA: 0x0006A308 File Offset: 0x00068508
		[Token(Token = "0x60113B5")]
		public static bool TryGetParser<T>(ParamRealType valueType, out ParamParser<T> result)
		{
			return default(bool);
		}

		// Token: 0x060113B6 RID: 70582 RVA: 0x0006A320 File Offset: 0x00068520
		[Token(Token = "0x60113B6")]
		public static bool TryGetParser<T>(out ParamParser<T> result, bool showWarning = true)
		{
			return default(bool);
		}

		// Token: 0x060113B7 RID: 70583 RVA: 0x0006A338 File Offset: 0x00068538
		[Token(Token = "0x60113B7")]
		[Address(RVA = "0x924150", Offset = "0x922D50", VA = "0x180924150")]
		public static bool TryGetParser(Type type, out IParamParser result, bool showWarning = true)
		{
			return default(bool);
		}

		// Token: 0x060113B8 RID: 70584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60113B8")]
		[Address(RVA = "0x923FF0", Offset = "0x922BF0", VA = "0x180923FF0")]
		public static ParamVariable ToVariable(ParamValue paramValue)
		{
			return null;
		}

		// Token: 0x060113B9 RID: 70585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60113B9")]
		[Address(RVA = "0x923E90", Offset = "0x922A90", VA = "0x180923E90")]
		public static void SetRaw(ParamValue paramValue, object value)
		{
		}

		// Token: 0x060113BA RID: 70586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60113BA")]
		public static void Set<T>(ParamValue paramValue, T value, bool force = false)
		{
		}

		// Token: 0x060113BB RID: 70587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60113BB")]
		public static void Set<T>(ParamValue paramValue, List<T> value, bool force = false)
		{
		}

		// Token: 0x060113BC RID: 70588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60113BC")]
		public static void SetValueAtIndex<T>(ParamValue paramValue, T value, int index)
		{
		}

		// Token: 0x060113BD RID: 70589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60113BD")]
		public static T Get<T>(ParamValue paramValue, T defaultValue)
		{
			return null;
		}

		// Token: 0x060113BE RID: 70590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60113BE")]
		public static T GetOrNew<T>(ParamValue paramValue, T defaultValue)
		{
			return null;
		}

		// Token: 0x060113BF RID: 70591 RVA: 0x0006A350 File Offset: 0x00068550
		[Token(Token = "0x60113BF")]
		public static bool TryGet<T>(ParamValue paramValue, out T value)
		{
			return default(bool);
		}

		// Token: 0x060113C0 RID: 70592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60113C0")]
		public static List<T> Get<T>(ParamValue paramValue, ref List<T> refList)
		{
			return null;
		}

		// Token: 0x060113C1 RID: 70593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60113C1")]
		public static T GetListItem<T>(ParamValue paramValue, int index, T defaultValue, bool showWarning)
		{
			return null;
		}

		// Token: 0x060113C2 RID: 70594 RVA: 0x0006A368 File Offset: 0x00068568
		[Token(Token = "0x60113C2")]
		public static bool TryGetListItem<T>(ParamValue paramValue, int index, out T value, bool showWarning)
		{
			return default(bool);
		}

		// Token: 0x0401346E RID: 78958
		[Token(Token = "0x401346E")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<ParamRealType, IParamParser> m_valueTypeParserDict;

		// Token: 0x0401346F RID: 78959
		[Token(Token = "0x401346F")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<Type, IParamParser> m_typeParserAllDict;

		// Token: 0x04013470 RID: 78960
		[Token(Token = "0x4013470")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<Type, IParamParser> m_typeParserBasicDict;

		// Token: 0x04013471 RID: 78961
		[Token(Token = "0x4013471")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04013472 RID: 78962
		[Token(Token = "0x4013472")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetAllParser;

		// Token: 0x04013473 RID: 78963
		[Token(Token = "0x4013473")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_TryGetRawParser;

		// Token: 0x04013474 RID: 78964
		[Token(Token = "0x4013474")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_TryGetParser;

		// Token: 0x04013475 RID: 78965
		[Token(Token = "0x4013475")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix1_TryGetParser;

		// Token: 0x04013476 RID: 78966
		[Token(Token = "0x4013476")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix2_TryGetParser;

		// Token: 0x04013477 RID: 78967
		[Token(Token = "0x4013477")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ToVariable;

		// Token: 0x04013478 RID: 78968
		[Token(Token = "0x4013478")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_SetRaw;

		// Token: 0x04013479 RID: 78969
		[Token(Token = "0x4013479")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_Set;

		// Token: 0x0401347A RID: 78970
		[Token(Token = "0x401347A")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix1_Set;

		// Token: 0x0401347B RID: 78971
		[Token(Token = "0x401347B")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_SetValueAtIndex;

		// Token: 0x0401347C RID: 78972
		[Token(Token = "0x401347C")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_Get;

		// Token: 0x0401347D RID: 78973
		[Token(Token = "0x401347D")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_GetOrNew;

		// Token: 0x0401347E RID: 78974
		[Token(Token = "0x401347E")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_TryGet;

		// Token: 0x0401347F RID: 78975
		[Token(Token = "0x401347F")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix1_Get;

		// Token: 0x04013480 RID: 78976
		[Token(Token = "0x4013480")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_GetListItem;

		// Token: 0x04013481 RID: 78977
		[Token(Token = "0x4013481")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_TryGetListItem;
	}
}
