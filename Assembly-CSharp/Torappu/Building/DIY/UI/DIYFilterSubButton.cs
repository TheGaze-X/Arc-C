using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.DIY.UI
{
	// Token: 0x0200197F RID: 6527
	[Token(Token = "0x200197F")]
	public class DIYFilterSubButton : MonoBehaviour, IHotfixable
	{
		// Token: 0x170012F5 RID: 4853
		// (get) Token: 0x0600A3C1 RID: 41921 RVA: 0x0003F8A0 File Offset: 0x0003DAA0
		// (set) Token: 0x0600A3C2 RID: 41922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170012F5")]
		public BuildingData.FurnitureSubType subType
		{
			[Token(Token = "0x600A3C1")]
			[Address(RVA = "0x31D9310", Offset = "0x31D7F10", VA = "0x1831D9310")]
			get
			{
				return BuildingData.FurnitureSubType.NONE;
			}
			[Token(Token = "0x600A3C2")]
			[Address(RVA = "0x31D93D0", Offset = "0x31D7FD0", VA = "0x1831D93D0")]
			set
			{
			}
		}

		// Token: 0x170012F6 RID: 4854
		// (get) Token: 0x0600A3C3 RID: 41923 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600A3C4 RID: 41924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170012F6")]
		public string textContent
		{
			[Token(Token = "0x600A3C3")]
			[Address(RVA = "0x31D9370", Offset = "0x31D7F70", VA = "0x1831D9370")]
			get
			{
				return null;
			}
			[Token(Token = "0x600A3C4")]
			[Address(RVA = "0x31D9440", Offset = "0x31D8040", VA = "0x1831D9440")]
			set
			{
			}
		}

		// Token: 0x0600A3C5 RID: 41925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A3C5")]
		[Address(RVA = "0x31D9060", Offset = "0x31D7C60", VA = "0x1831D9060")]
		public void OnButtonPressed()
		{
		}

		// Token: 0x0600A3C6 RID: 41926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A3C6")]
		[Address(RVA = "0x31D9150", Offset = "0x31D7D50", VA = "0x1831D9150")]
		public void SetTextColor(Color color)
		{
		}

		// Token: 0x0600A3C7 RID: 41927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A3C7")]
		[Address(RVA = "0x31D9200", Offset = "0x31D7E00", VA = "0x1831D9200")]
		public void SetWidth(float width)
		{
		}

		// Token: 0x0600A3C8 RID: 41928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A3C8")]
		[Address(RVA = "0x31D90D0", Offset = "0x31D7CD0", VA = "0x1831D90D0")]
		public void RenderTrackPointStatus(bool hasTrackpoint)
		{
		}

		// Token: 0x0600A3C9 RID: 41929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A3C9")]
		[Address(RVA = "0x31D92B0", Offset = "0x31D7EB0", VA = "0x1831D92B0")]
		public DIYFilterSubButton()
		{
		}

		// Token: 0x04009A79 RID: 39545
		[Token(Token = "0x4009A79")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _text;

		// Token: 0x04009A7A RID: 39546
		[Token(Token = "0x4009A7A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _pnlTrackpoint;

		// Token: 0x04009A7B RID: 39547
		[Token(Token = "0x4009A7B")]
		[FieldOffset(Offset = "0x28")]
		[NonSerialized]
		public Action<BuildingData.FurnitureSubType> onSubTypePressed;

		// Token: 0x04009A7C RID: 39548
		[Token(Token = "0x4009A7C")]
		[FieldOffset(Offset = "0x30")]
		private BuildingData.FurnitureSubType m_subType;

		// Token: 0x04009A7D RID: 39549
		[Token(Token = "0x4009A7D")]
		[FieldOffset(Offset = "0x38")]
		private string m_textContent;

		// Token: 0x04009A7E RID: 39550
		[Token(Token = "0x4009A7E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_subType;

		// Token: 0x04009A7F RID: 39551
		[Token(Token = "0x4009A7F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_subType;

		// Token: 0x04009A80 RID: 39552
		[Token(Token = "0x4009A80")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_textContent;

		// Token: 0x04009A81 RID: 39553
		[Token(Token = "0x4009A81")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_textContent;

		// Token: 0x04009A82 RID: 39554
		[Token(Token = "0x4009A82")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnButtonPressed;

		// Token: 0x04009A83 RID: 39555
		[Token(Token = "0x4009A83")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_SetTextColor;

		// Token: 0x04009A84 RID: 39556
		[Token(Token = "0x4009A84")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SetWidth;

		// Token: 0x04009A85 RID: 39557
		[Token(Token = "0x4009A85")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_RenderTrackPointStatus;

		// Token: 0x04009A86 RID: 39558
		[Token(Token = "0x4009A86")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
