using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Home.Activity
{
	// Token: 0x02004C76 RID: 19574
	[Token(Token = "0x2004C76")]
	public class OpenServerChainLoginView : MonoBehaviour
	{
		// Token: 0x0601D5B4 RID: 120244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D5B4")]
		[Address(RVA = "0x16EAFB0", Offset = "0x16E9BB0", VA = "0x1816EAFB0")]
		public void Initialize()
		{
		}

		// Token: 0x0601D5B5 RID: 120245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D5B5")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public OpenServerChainLoginView()
		{
		}

		// Token: 0x04026A02 RID: 158210
		[Token(Token = "0x4026A02")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _viewContainer;

		// Token: 0x04026A03 RID: 158211
		[Token(Token = "0x4026A03")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _chainLoginDescription;

		// Token: 0x04026A04 RID: 158212
		[Token(Token = "0x4026A04")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _chainLoginPic;

		// Token: 0x04026A05 RID: 158213
		[Token(Token = "0x4026A05")]
		[FieldOffset(Offset = "0x30")]
		[NonSerialized]
		public Action<int> OnGetChainLogin;

		// Token: 0x04026A06 RID: 158214
		[Token(Token = "0x4026A06")]
		[FieldOffset(Offset = "0x38")]
		private OpenServerChainLoginView.Adapter m_adapter;

		// Token: 0x04026A07 RID: 158215
		[Token(Token = "0x4026A07")]
		[FieldOffset(Offset = "0x40")]
		private IList<ChainLoginData> m_viewDataSource;

		// Token: 0x04026A08 RID: 158216
		[Token(Token = "0x4026A08")]
		[FieldOffset(Offset = "0x48")]
		private UIStateFinder m_stateFinder;

		// Token: 0x02004C77 RID: 19575
		[Token(Token = "0x2004C77")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x170044E7 RID: 17639
			// (get) Token: 0x0601D5B6 RID: 120246 RVA: 0x000AB3C0 File Offset: 0x000A95C0
			[Token(Token = "0x170044E7")]
			public override int count
			{
				[Token(Token = "0x601D5B6")]
				[Address(RVA = "0x16DD990", Offset = "0x16DC590", VA = "0x1816DD990", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601D5B7 RID: 120247 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D5B7")]
			[Address(RVA = "0x16DD710", Offset = "0x16DC310", VA = "0x1816DD710")]
			public Adapter(OpenServerChainLoginView owner)
			{
			}

			// Token: 0x0601D5B8 RID: 120248 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601D5B8")]
			[Address(RVA = "0x16DD3B0", Offset = "0x16DBFB0", VA = "0x1816DD3B0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04026A09 RID: 158217
			[Token(Token = "0x4026A09")]
			[FieldOffset(Offset = "0x20")]
			private OpenServerChainLoginView m_owner;

			// Token: 0x04026A0A RID: 158218
			[Token(Token = "0x4026A0A")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04026A0B RID: 158219
			[Token(Token = "0x4026A0B")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04026A0C RID: 158220
			[Token(Token = "0x4026A0C")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
