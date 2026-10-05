using System;
using AdvancedInspector;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using UnityEngine;
using XLua;

namespace Torappu.UI.Home.Theme
{
	// Token: 0x02004C5A RID: 19546
	[Token(Token = "0x2004C5A")]
	public abstract class HomeThemeElemBase<T> : MonoBehaviour, IHotfixable, IHomeThemeElemBase where T : HomeThemeElemData, new()
	{
		// Token: 0x170044E1 RID: 17633
		// (get) Token: 0x0601D53B RID: 120123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170044E1")]
		public string elemName
		{
			[Token(Token = "0x601D53B")]
			get
			{
				return null;
			}
		}

		// Token: 0x170044E2 RID: 17634
		// (get) Token: 0x0601D53C RID: 120124 RVA: 0x000AB300 File Offset: 0x000A9500
		// (set) Token: 0x0601D53D RID: 120125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170044E2")]
		[Inspect]
		public bool configSerializable
		{
			[Token(Token = "0x601D53C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x601D53D")]
			set
			{
			}
		}

		// Token: 0x0601D53E RID: 120126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D53E")]
		public void Apply(string targetName, JObject jdata, HomeTheme theme)
		{
		}

		// Token: 0x0601D53F RID: 120127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D53F")]
		public void ApplyEmpty()
		{
		}

		// Token: 0x0601D540 RID: 120128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D540")]
		public virtual void OnGenData()
		{
		}

		// Token: 0x0601D541 RID: 120129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D541")]
		public HomeThemeElemData GenData(AssetPathConvertor pathConvertor)
		{
			return null;
		}

		// Token: 0x0601D542 RID: 120130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D542")]
		public void ClearReference()
		{
		}

		// Token: 0x0601D543 RID: 120131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D543")]
		public T GetData(AssetPathConvertor pathConvertor)
		{
			return null;
		}

		// Token: 0x0601D544 RID: 120132
		[Token(Token = "0x601D544")]
		protected abstract void OnApply(T data, HomeTheme theme);

		// Token: 0x0601D545 RID: 120133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D545")]
		protected virtual void OnApplyEmpty()
		{
		}

		// Token: 0x0601D546 RID: 120134
		[Token(Token = "0x601D546")]
		protected abstract void OnFillData(T data, AssetPathConvertor pathConvertor);

		// Token: 0x0601D547 RID: 120135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D547")]
		protected virtual void OnClearRef()
		{
		}

		// Token: 0x0601D548 RID: 120136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D548")]
		protected HomeThemeElemBase()
		{
		}

		// Token: 0x0402696C RID: 158060
		[Token(Token = "0x402696C")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private string _elemName;

		// Token: 0x0402696D RID: 158061
		[Token(Token = "0x402696D")]
		[FieldOffset(Offset = "0x0")]
		private bool m_configSerializable;

		// Token: 0x0402696E RID: 158062
		[Token(Token = "0x402696E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_elemName;

		// Token: 0x0402696F RID: 158063
		[Token(Token = "0x402696F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_configSerializable;

		// Token: 0x04026970 RID: 158064
		[Token(Token = "0x4026970")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_configSerializable;

		// Token: 0x04026971 RID: 158065
		[Token(Token = "0x4026971")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Apply;

		// Token: 0x04026972 RID: 158066
		[Token(Token = "0x4026972")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ApplyEmpty;

		// Token: 0x04026973 RID: 158067
		[Token(Token = "0x4026973")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnGenData;

		// Token: 0x04026974 RID: 158068
		[Token(Token = "0x4026974")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GenData;

		// Token: 0x04026975 RID: 158069
		[Token(Token = "0x4026975")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ClearReference;

		// Token: 0x04026976 RID: 158070
		[Token(Token = "0x4026976")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetData;

		// Token: 0x04026977 RID: 158071
		[Token(Token = "0x4026977")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnApplyEmpty;

		// Token: 0x04026978 RID: 158072
		[Token(Token = "0x4026978")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnClearRef;

		// Token: 0x04026979 RID: 158073
		[Token(Token = "0x4026979")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
