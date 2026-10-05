using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Building.DIY.UI
{
	// Token: 0x02001973 RID: 6515
	[Token(Token = "0x2001973")]
	public class DIYComfortDetailGroupAdapter : LoopScrollAdapter<DIYComfortDetailGroupAdapter.ViewHolder, DIYComfortDetailView.DIYComfortDetailLine>
	{
		// Token: 0x0600A3A2 RID: 41890 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A3A2")]
		[Address(RVA = "0x31D7130", Offset = "0x31D5D30", VA = "0x1831D7130", Slot = "8")]
		public override GameObject CreateView(Transform parent)
		{
			return null;
		}

		// Token: 0x0600A3A3 RID: 41891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A3A3")]
		[Address(RVA = "0x31D71E0", Offset = "0x31D5DE0", VA = "0x1831D71E0", Slot = "13")]
		public override void UpdateView(int position, GameObject view, DIYComfortDetailGroupAdapter.ViewHolder holder, DIYComfortDetailView.DIYComfortDetailLine data)
		{
		}

		// Token: 0x0600A3A4 RID: 41892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A3A4")]
		[Address(RVA = "0x31D72F0", Offset = "0x31D5EF0", VA = "0x1831D72F0")]
		public DIYComfortDetailGroupAdapter()
		{
		}

		// Token: 0x04009A3B RID: 39483
		[Token(Token = "0x4009A3B")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _linePrefab;

		// Token: 0x04009A3C RID: 39484
		[Token(Token = "0x4009A3C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CreateView;

		// Token: 0x04009A3D RID: 39485
		[Token(Token = "0x4009A3D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x04009A3E RID: 39486
		[Token(Token = "0x4009A3E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001974 RID: 6516
		[Token(Token = "0x2001974")]
		public class ViewHolder
		{
			// Token: 0x0600A3A5 RID: 41893 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A3A5")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ViewHolder()
			{
			}
		}
	}
}
