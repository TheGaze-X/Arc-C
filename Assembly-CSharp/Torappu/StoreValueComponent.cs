using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu
{
	// Token: 0x0200057E RID: 1406
	[Token(Token = "0x200057E")]
	public class StoreValueComponent : MonoBehaviour, IHotfixable
	{
		// Token: 0x06005BD4 RID: 23508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BD4")]
		[Address(RVA = "0x1CF94A0", Offset = "0x1CF80A0", VA = "0x181CF94A0")]
		private void _RuntimeInitIfNot()
		{
		}

		// Token: 0x06005BD5 RID: 23509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BD5")]
		[Address(RVA = "0x1CF8A80", Offset = "0x1CF7680", VA = "0x181CF8A80")]
		private void _ConvertRuntimeStores()
		{
		}

		// Token: 0x06005BD6 RID: 23510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005BD6")]
		[Address(RVA = "0x1CF91D0", Offset = "0x1CF7DD0", VA = "0x181CF91D0")]
		private Component _GetAsComponent(string key, Type componentType)
		{
			return null;
		}

		// Token: 0x06005BD7 RID: 23511 RVA: 0x0002EF68 File Offset: 0x0002D168
		[Token(Token = "0x6005BD7")]
		[Address(RVA = "0x1CF86B0", Offset = "0x1CF72B0", VA = "0x181CF86B0")]
		public static float StrToFloat(string str)
		{
			return 0f;
		}

		// Token: 0x06005BD8 RID: 23512 RVA: 0x0002EF80 File Offset: 0x0002D180
		[Token(Token = "0x6005BD8")]
		[Address(RVA = "0x1CF8740", Offset = "0x1CF7340", VA = "0x181CF8740")]
		public static int StrToInt(string str)
		{
			return 0;
		}

		// Token: 0x06005BD9 RID: 23513 RVA: 0x0002EF98 File Offset: 0x0002D198
		[Token(Token = "0x6005BD9")]
		[Address(RVA = "0x1CF87D0", Offset = "0x1CF73D0", VA = "0x181CF87D0")]
		public static Vector3 StrToVector3(string str)
		{
			return default(Vector3);
		}

		// Token: 0x06005BDA RID: 23514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005BDA")]
		[Address(RVA = "0x1CF8970", Offset = "0x1CF7570", VA = "0x181CF8970")]
		public static string Vector3ToStr(Vector3 vector)
		{
			return null;
		}

		// Token: 0x06005BDB RID: 23515 RVA: 0x0002EFB0 File Offset: 0x0002D1B0
		[Token(Token = "0x6005BDB")]
		[Address(RVA = "0x1CF8610", Offset = "0x1CF7210", VA = "0x181CF8610")]
		public static Color StrToColor(string str)
		{
			return default(Color);
		}

		// Token: 0x06005BDC RID: 23516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005BDC")]
		[Address(RVA = "0x1CF80F0", Offset = "0x1CF6CF0", VA = "0x181CF80F0")]
		public static string ColorToStr(Color color)
		{
			return null;
		}

		// Token: 0x06005BDD RID: 23517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005BDD")]
		public TBindings GetOrCreateBindings<TBindings>() where TBindings : StoreValueComponent.Bindings, new()
		{
			return null;
		}

		// Token: 0x06005BDE RID: 23518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005BDE")]
		[Address(RVA = "0x1CF8470", Offset = "0x1CF7070", VA = "0x181CF8470")]
		public string GetString(string key, bool allowNotFound = false)
		{
			return null;
		}

		// Token: 0x06005BDF RID: 23519 RVA: 0x0002EFC8 File Offset: 0x0002D1C8
		[Token(Token = "0x6005BDF")]
		[Address(RVA = "0x1CF83B0", Offset = "0x1CF6FB0", VA = "0x181CF83B0")]
		public int GetInt(string key, bool allowNotFound = false)
		{
			return 0;
		}

		// Token: 0x06005BE0 RID: 23520 RVA: 0x0002EFE0 File Offset: 0x0002D1E0
		[Token(Token = "0x6005BE0")]
		[Address(RVA = "0x1CF82F0", Offset = "0x1CF6EF0", VA = "0x181CF82F0")]
		public float GetFloat(string key, bool allowNotFound = false)
		{
			return 0f;
		}

		// Token: 0x06005BE1 RID: 23521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005BE1")]
		public TObj GetObject<TObj>(string key, bool allowNotFound = false) where TObj : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x06005BE2 RID: 23522 RVA: 0x0002EFF8 File Offset: 0x0002D1F8
		[Token(Token = "0x6005BE2")]
		[Address(RVA = "0x1CF8530", Offset = "0x1CF7130", VA = "0x181CF8530")]
		public Vector3 GetVector3(string key, bool allowNotFound = false)
		{
			return default(Vector3);
		}

		// Token: 0x06005BE3 RID: 23523 RVA: 0x0002F010 File Offset: 0x0002D210
		[Token(Token = "0x6005BE3")]
		[Address(RVA = "0x1CF8220", Offset = "0x1CF6E20", VA = "0x181CF8220")]
		public Color GetColor(string key, bool allowNotFound = false)
		{
			return default(Color);
		}

		// Token: 0x06005BE4 RID: 23524 RVA: 0x0002F028 File Offset: 0x0002D228
		[Token(Token = "0x6005BE4")]
		[Address(RVA = "0x1CF81B0", Offset = "0x1CF6DB0", VA = "0x181CF81B0")]
		public StoreValueComponent.ObjectEnumerator EnumerateObjects()
		{
			return default(StoreValueComponent.ObjectEnumerator);
		}

		// Token: 0x06005BE5 RID: 23525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005BE5")]
		private T _GetValue<T>(ListDict<string, T> dict, string key, bool allowNotFound)
		{
			return null;
		}

		// Token: 0x06005BE6 RID: 23526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BE6")]
		[Address(RVA = "0x1CF9040", Offset = "0x1CF7C40", VA = "0x181CF9040")]
		private void _ErrorOnKeyNotFound(string key, Type type)
		{
		}

		// Token: 0x06005BE7 RID: 23527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BE7")]
		[Address(RVA = "0x1CF9510", Offset = "0x1CF8110", VA = "0x181CF9510")]
		public StoreValueComponent()
		{
		}

		// Token: 0x04002158 RID: 8536
		[Token(Token = "0x4002158")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<StoreValueComponent.ObjectRef> _objects;

		// Token: 0x04002159 RID: 8537
		[Token(Token = "0x4002159")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<StoreValueComponent.Value> _values;

		// Token: 0x0400215A RID: 8538
		[Token(Token = "0x400215A")]
		[FieldOffset(Offset = "0x28")]
		private bool m_isInited;

		// Token: 0x0400215B RID: 8539
		[Token(Token = "0x400215B")]
		[FieldOffset(Offset = "0x30")]
		private ListDict<string, UnityEngine.Object> m_objectDict;

		// Token: 0x0400215C RID: 8540
		[Token(Token = "0x400215C")]
		[FieldOffset(Offset = "0x38")]
		private ListDict<string, string> m_strDict;

		// Token: 0x0400215D RID: 8541
		[Token(Token = "0x400215D")]
		[FieldOffset(Offset = "0x40")]
		private ListDict<string, Vector3> m_vectorDict;

		// Token: 0x0400215E RID: 8542
		[Token(Token = "0x400215E")]
		[FieldOffset(Offset = "0x48")]
		private ListDict<string, float> m_floatDict;

		// Token: 0x0400215F RID: 8543
		[Token(Token = "0x400215F")]
		[FieldOffset(Offset = "0x50")]
		private ListDict<string, GetComponentCache> m_compDict;

		// Token: 0x04002160 RID: 8544
		[Token(Token = "0x4002160")]
		[FieldOffset(Offset = "0x58")]
		private ListDict<string, Color> m_colorDict;

		// Token: 0x04002161 RID: 8545
		[Token(Token = "0x4002161")]
		[FieldOffset(Offset = "0x60")]
		private ListDict<string, int> m_intDict;

		// Token: 0x04002162 RID: 8546
		[Token(Token = "0x4002162")]
		[FieldOffset(Offset = "0x68")]
		[NonSerialized]
		public object userdata;

		// Token: 0x04002163 RID: 8547
		[Token(Token = "0x4002163")]
		[FieldOffset(Offset = "0x70")]
		[NonSerialized]
		private StoreValueComponent.Bindings m_bindings;

		// Token: 0x04002164 RID: 8548
		[Token(Token = "0x4002164")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__RuntimeInitIfNot;

		// Token: 0x04002165 RID: 8549
		[Token(Token = "0x4002165")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__ConvertRuntimeStores;

		// Token: 0x04002166 RID: 8550
		[Token(Token = "0x4002166")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GetAsComponent;

		// Token: 0x04002167 RID: 8551
		[Token(Token = "0x4002167")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_StrToFloat;

		// Token: 0x04002168 RID: 8552
		[Token(Token = "0x4002168")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_StrToInt;

		// Token: 0x04002169 RID: 8553
		[Token(Token = "0x4002169")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_StrToVector3;

		// Token: 0x0400216A RID: 8554
		[Token(Token = "0x400216A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Vector3ToStr;

		// Token: 0x0400216B RID: 8555
		[Token(Token = "0x400216B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_StrToColor;

		// Token: 0x0400216C RID: 8556
		[Token(Token = "0x400216C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_ColorToStr;

		// Token: 0x0400216D RID: 8557
		[Token(Token = "0x400216D")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetOrCreateBindings;

		// Token: 0x0400216E RID: 8558
		[Token(Token = "0x400216E")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_GetString;

		// Token: 0x0400216F RID: 8559
		[Token(Token = "0x400216F")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_GetInt;

		// Token: 0x04002170 RID: 8560
		[Token(Token = "0x4002170")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_GetFloat;

		// Token: 0x04002171 RID: 8561
		[Token(Token = "0x4002171")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_GetObject;

		// Token: 0x04002172 RID: 8562
		[Token(Token = "0x4002172")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_GetVector3;

		// Token: 0x04002173 RID: 8563
		[Token(Token = "0x4002173")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_GetColor;

		// Token: 0x04002174 RID: 8564
		[Token(Token = "0x4002174")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_EnumerateObjects;

		// Token: 0x04002175 RID: 8565
		[Token(Token = "0x4002175")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__GetValue;

		// Token: 0x04002176 RID: 8566
		[Token(Token = "0x4002176")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__ErrorOnKeyNotFound;

		// Token: 0x04002177 RID: 8567
		[Token(Token = "0x4002177")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200057F RID: 1407
		[Token(Token = "0x200057F")]
		[Serializable]
		private struct ObjectRef
		{
			// Token: 0x06005BE8 RID: 23528 RVA: 0x0002F040 File Offset: 0x0002D240
			[Token(Token = "0x6005BE8")]
			[Address(RVA = "0x1CF7AA0", Offset = "0x1CF66A0", VA = "0x181CF7AA0")]
			public bool IsEmpty()
			{
				return default(bool);
			}

			// Token: 0x04002178 RID: 8568
			[Token(Token = "0x4002178")]
			[FieldOffset(Offset = "0x0")]
			public string key;

			// Token: 0x04002179 RID: 8569
			[Token(Token = "0x4002179")]
			[FieldOffset(Offset = "0x8")]
			public UnityEngine.Object value;
		}

		// Token: 0x02000580 RID: 1408
		[Token(Token = "0x2000580")]
		public enum ValueType
		{
			// Token: 0x0400217B RID: 8571
			[Token(Token = "0x400217B")]
			STRING,
			// Token: 0x0400217C RID: 8572
			[Token(Token = "0x400217C")]
			VECTOR3,
			// Token: 0x0400217D RID: 8573
			[Token(Token = "0x400217D")]
			FLOAT,
			// Token: 0x0400217E RID: 8574
			[Token(Token = "0x400217E")]
			INT,
			// Token: 0x0400217F RID: 8575
			[Token(Token = "0x400217F")]
			COLOR
		}

		// Token: 0x02000581 RID: 1409
		[Token(Token = "0x2000581")]
		[Serializable]
		private struct Value
		{
			// Token: 0x06005BE9 RID: 23529 RVA: 0x0002F058 File Offset: 0x0002D258
			[Token(Token = "0x6005BE9")]
			[Address(RVA = "0x12E7370", Offset = "0x12E5F70", VA = "0x1812E7370")]
			public bool IsEmpty()
			{
				return default(bool);
			}

			// Token: 0x04002180 RID: 8576
			[Token(Token = "0x4002180")]
			[FieldOffset(Offset = "0x0")]
			public string key;

			// Token: 0x04002181 RID: 8577
			[Token(Token = "0x4002181")]
			[FieldOffset(Offset = "0x8")]
			public string value;

			// Token: 0x04002182 RID: 8578
			[Token(Token = "0x4002182")]
			[FieldOffset(Offset = "0x10")]
			public StoreValueComponent.ValueType type;
		}

		// Token: 0x02000582 RID: 1410
		[Token(Token = "0x2000582")]
		public struct ObjectEnumerator
		{
			// Token: 0x06005BEA RID: 23530 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005BEA")]
			[Address(RVA = "0xE7C280", Offset = "0xE7AE80", VA = "0x180E7C280")]
			public ObjectEnumerator(StoreValueComponent target)
			{
			}

			// Token: 0x06005BEB RID: 23531 RVA: 0x0002F070 File Offset: 0x0002D270
			[Token(Token = "0x6005BEB")]
			[Address(RVA = "0x1CF79C0", Offset = "0x1CF65C0", VA = "0x181CF79C0")]
			public List<KeyValuePair<string, UnityEngine.Object>>.Enumerator GetEnumerator()
			{
				return default(List<KeyValuePair<string, UnityEngine.Object>>.Enumerator);
			}

			// Token: 0x04002183 RID: 8579
			[Token(Token = "0x4002183")]
			[FieldOffset(Offset = "0x0")]
			private StoreValueComponent m_target;
		}

		// Token: 0x02000583 RID: 1411
		[Token(Token = "0x2000583")]
		public abstract class Bindings
		{
			// Token: 0x06005BEC RID: 23532
			[Token(Token = "0x6005BEC")]
			public abstract void Bind(StoreValueComponent store);

			// Token: 0x06005BED RID: 23533 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005BED")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			protected Bindings()
			{
			}
		}
	}
}
