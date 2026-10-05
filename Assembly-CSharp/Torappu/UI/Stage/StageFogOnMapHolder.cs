using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006966 RID: 26982
	[Token(Token = "0x2006966")]
	[SelectionBase]
	public class StageFogOnMapHolder : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005B28 RID: 23336
		// (get) Token: 0x060269D0 RID: 158160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005B28")]
		public string fogId
		{
			[Token(Token = "0x60269D0")]
			[Address(RVA = "0x21AC0C0", Offset = "0x21AACC0", VA = "0x1821AC0C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005B29 RID: 23337
		// (get) Token: 0x060269D1 RID: 158161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005B29")]
		public StageFogOnMapBase fog
		{
			[Token(Token = "0x60269D1")]
			[Address(RVA = "0x21AC120", Offset = "0x21AAD20", VA = "0x1821AC120")]
			get
			{
				return null;
			}
		}

		// Token: 0x060269D2 RID: 158162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60269D2")]
		[Address(RVA = "0x21AC060", Offset = "0x21AAC60", VA = "0x1821AC060")]
		public StageFogOnMapHolder()
		{
		}

		// Token: 0x040367D9 RID: 223193
		[Token(Token = "0x40367D9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[HideInInspector]
		private string _fogId;

		// Token: 0x040367DA RID: 223194
		[Token(Token = "0x40367DA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[FormerlySerializedAs("_prefab")]
		private StageFogOnMapBase _fog;

		// Token: 0x040367DB RID: 223195
		[Token(Token = "0x40367DB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_fogId;

		// Token: 0x040367DC RID: 223196
		[Token(Token = "0x40367DC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_fog;

		// Token: 0x040367DD RID: 223197
		[Token(Token = "0x40367DD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
