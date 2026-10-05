using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI.SM
{
	// Token: 0x02001CBA RID: 7354
	[Token(Token = "0x2001CBA")]
	public class BuildingSMRoomGroupTitleView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0600B643 RID: 46659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B643")]
		[Address(RVA = "0x3305380", Offset = "0x3303F80", VA = "0x183305380")]
		public BuildingSMRoomGroupTitleView()
		{
		}

		// Token: 0x0400B326 RID: 45862
		[Token(Token = "0x400B326")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _preferHeight;

		// Token: 0x0400B327 RID: 45863
		[Token(Token = "0x400B327")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textTitle;

		// Token: 0x0400B328 RID: 45864
		[Token(Token = "0x400B328")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _colorPart;

		// Token: 0x0400B329 RID: 45865
		[Token(Token = "0x400B329")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001CBB RID: 7355
		[Token(Token = "0x2001CBB")]
		public class VirtualView : UIRecycleLayoutAdapter.VirtualView<BuildingSMRoomGroupTitleView>
		{
			// Token: 0x0600B644 RID: 46660 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B644")]
			[Address(RVA = "0x331C610", Offset = "0x331B210", VA = "0x18331C610")]
			public VirtualView(BuildingSMRoomGroupTitleView prefab)
			{
			}

			// Token: 0x0600B645 RID: 46661 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B645")]
			[Address(RVA = "0x331C460", Offset = "0x331B060", VA = "0x18331C460")]
			public void SetTitle(string title)
			{
			}

			// Token: 0x0600B646 RID: 46662 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B646")]
			[Address(RVA = "0x331C180", Offset = "0x331AD80", VA = "0x18331C180")]
			public void SetColor(Color color)
			{
			}

			// Token: 0x0600B647 RID: 46663 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600B647")]
			[Address(RVA = "0x331BD70", Offset = "0x331A970", VA = "0x18331BD70", Slot = "12")]
			public override GameObject GetPrefab()
			{
				return null;
			}

			// Token: 0x0600B648 RID: 46664 RVA: 0x00044EB0 File Offset: 0x000430B0
			[Token(Token = "0x600B648")]
			[Address(RVA = "0x331BDE0", Offset = "0x331A9E0", VA = "0x18331BDE0", Slot = "13")]
			public override float GetPreferSize()
			{
				return 0f;
			}

			// Token: 0x0600B649 RID: 46665 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B649")]
			[Address(RVA = "0x331BF90", Offset = "0x331AB90", VA = "0x18331BF90", Slot = "10")]
			protected override void OnViewAttached()
			{
			}

			// Token: 0x0600B64A RID: 46666 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B64A")]
			[Address(RVA = "0x331C120", Offset = "0x331AD20", VA = "0x18331C120", Slot = "11")]
			protected override void OnViewDetached()
			{
			}

			// Token: 0x0400B32A RID: 45866
			[Token(Token = "0x400B32A")]
			[FieldOffset(Offset = "0x20")]
			private BuildingSMRoomGroupTitleView m_prefab;

			// Token: 0x0400B32B RID: 45867
			[Token(Token = "0x400B32B")]
			[FieldOffset(Offset = "0x28")]
			private string m_title;

			// Token: 0x0400B32C RID: 45868
			[Token(Token = "0x400B32C")]
			[FieldOffset(Offset = "0x30")]
			private Color m_color;

			// Token: 0x0400B32D RID: 45869
			[Token(Token = "0x400B32D")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0400B32E RID: 45870
			[Token(Token = "0x400B32E")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_SetTitle;

			// Token: 0x0400B32F RID: 45871
			[Token(Token = "0x400B32F")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_SetColor;

			// Token: 0x0400B330 RID: 45872
			[Token(Token = "0x400B330")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GetPrefab;

			// Token: 0x0400B331 RID: 45873
			[Token(Token = "0x400B331")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_GetPreferSize;

			// Token: 0x0400B332 RID: 45874
			[Token(Token = "0x400B332")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_OnViewAttached;

			// Token: 0x0400B333 RID: 45875
			[Token(Token = "0x400B333")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_OnViewDetached;
		}
	}
}
