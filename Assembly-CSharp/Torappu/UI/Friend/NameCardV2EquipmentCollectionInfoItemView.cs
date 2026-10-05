using System;
using Il2CppDummyDll;
using Torappu.UI.UniEquipArchive;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004E09 RID: 19977
	[Token(Token = "0x2004E09")]
	public class NameCardV2EquipmentCollectionInfoItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700460B RID: 17931
		// (get) Token: 0x0601DDA7 RID: 122279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700460B")]
		public UIColorGraphic needChangeStyleText
		{
			[Token(Token = "0x601DDA7")]
			[Address(RVA = "0x17753B0", Offset = "0x1773FB0", VA = "0x1817753B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700460C RID: 17932
		// (get) Token: 0x0601DDA8 RID: 122280 RVA: 0x000AC890 File Offset: 0x000AAA90
		[Token(Token = "0x1700460C")]
		public bool showTotal
		{
			[Token(Token = "0x601DDA8")]
			[Address(RVA = "0x1775410", Offset = "0x1774010", VA = "0x181775410")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601DDA9 RID: 122281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DDA9")]
		[Address(RVA = "0x1774F80", Offset = "0x1773B80", VA = "0x181774F80")]
		public void Render(NameCardV2EquipmentCollectionInfoItemViewModel itemViewModel)
		{
		}

		// Token: 0x0601DDAA RID: 122282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DDAA")]
		[Address(RVA = "0x1775240", Offset = "0x1773E40", VA = "0x181775240")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601DDAB RID: 122283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DDAB")]
		[Address(RVA = "0x1775350", Offset = "0x1773F50", VA = "0x181775350")]
		public NameCardV2EquipmentCollectionInfoItemView()
		{
		}

		// Token: 0x0402790F RID: 162063
		[Token(Token = "0x402790F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _txtTitle;

		// Token: 0x04027910 RID: 162064
		[Token(Token = "0x4027910")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _txtCurCount;

		// Token: 0x04027911 RID: 162065
		[Token(Token = "0x4027911")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _txtTotalCount;

		// Token: 0x04027912 RID: 162066
		[Token(Token = "0x4027912")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAnimationLocation _switchAnim;

		// Token: 0x04027913 RID: 162067
		[Token(Token = "0x4027913")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIColorGraphic _needChangeStyleText;

		// Token: 0x04027914 RID: 162068
		[Token(Token = "0x4027914")]
		[FieldOffset(Offset = "0x48")]
		private bool m_hasInited;

		// Token: 0x04027915 RID: 162069
		[Token(Token = "0x4027915")]
		[FieldOffset(Offset = "0x4C")]
		private UniEquipArchiveCollectionInfoType m_cachedType;

		// Token: 0x04027916 RID: 162070
		[Token(Token = "0x4027916")]
		[FieldOffset(Offset = "0x50")]
		private AnimationSwitchTween m_switchTween;

		// Token: 0x04027917 RID: 162071
		[Token(Token = "0x4027917")]
		[FieldOffset(Offset = "0x58")]
		private bool m_showTotal;

		// Token: 0x04027918 RID: 162072
		[Token(Token = "0x4027918")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_needChangeStyleText;

		// Token: 0x04027919 RID: 162073
		[Token(Token = "0x4027919")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_showTotal;

		// Token: 0x0402791A RID: 162074
		[Token(Token = "0x402791A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402791B RID: 162075
		[Token(Token = "0x402791B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402791C RID: 162076
		[Token(Token = "0x402791C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
