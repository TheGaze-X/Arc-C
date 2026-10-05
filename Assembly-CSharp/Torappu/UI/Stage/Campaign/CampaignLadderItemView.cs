using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage.Campaign
{
	// Token: 0x02006A48 RID: 27208
	[Token(Token = "0x2006A48")]
	public class CampaignLadderItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06026E40 RID: 159296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E40")]
		[Address(RVA = "0x21E95B0", Offset = "0x21E81B0", VA = "0x1821E95B0")]
		public void RenderView(LadderItem ladderItemData)
		{
		}

		// Token: 0x06026E41 RID: 159297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E41")]
		[Address(RVA = "0x21E9770", Offset = "0x21E8370", VA = "0x1821E9770")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06026E42 RID: 159298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E42")]
		[Address(RVA = "0x21E9890", Offset = "0x21E8490", VA = "0x1821E9890")]
		public CampaignLadderItemView()
		{
		}

		// Token: 0x04036FEE RID: 225262
		[Token(Token = "0x4036FEE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x04036FEF RID: 225263
		[Token(Token = "0x4036FEF")]
		[FieldOffset(Offset = "0x20")]
		private LadderItem m_ladderItem;

		// Token: 0x04036FF0 RID: 225264
		[Token(Token = "0x4036FF0")]
		[FieldOffset(Offset = "0x28")]
		private bool m_hasInited;

		// Token: 0x04036FF1 RID: 225265
		[Token(Token = "0x4036FF1")]
		[FieldOffset(Offset = "0x30")]
		private CampaignLadderItemView.Adapter m_adapter;

		// Token: 0x04036FF2 RID: 225266
		[Token(Token = "0x4036FF2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderView;

		// Token: 0x04036FF3 RID: 225267
		[Token(Token = "0x4036FF3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04036FF4 RID: 225268
		[Token(Token = "0x4036FF4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006A49 RID: 27209
		[Token(Token = "0x2006A49")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x06026E43 RID: 159299 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026E43")]
			[Address(RVA = "0x21E85E0", Offset = "0x21E71E0", VA = "0x1821E85E0")]
			public Adapter(CampaignLadderItemView context)
			{
			}

			// Token: 0x17005BB6 RID: 23478
			// (get) Token: 0x06026E44 RID: 159300 RVA: 0x000CC978 File Offset: 0x000CAB78
			[Token(Token = "0x17005BB6")]
			public override int count
			{
				[Token(Token = "0x6026E44")]
				[Address(RVA = "0x21E8660", Offset = "0x21E7260", VA = "0x1821E8660", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06026E45 RID: 159301 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6026E45")]
			[Address(RVA = "0x21E8300", Offset = "0x21E6F00", VA = "0x1821E8300", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04036FF5 RID: 225269
			[Token(Token = "0x4036FF5")]
			[FieldOffset(Offset = "0x20")]
			private CampaignLadderItemView m_context;

			// Token: 0x04036FF6 RID: 225270
			[Token(Token = "0x4036FF6")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04036FF7 RID: 225271
			[Token(Token = "0x4036FF7")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04036FF8 RID: 225272
			[Token(Token = "0x4036FF8")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
