using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.UniEquip
{
	// Token: 0x02003C4B RID: 15435
	[Token(Token = "0x2003C4B")]
	public class UniEquipShowView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06018206 RID: 98822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018206")]
		[Address(RVA = "0x109C560", Offset = "0x109B160", VA = "0x18109C560")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06018207 RID: 98823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018207")]
		[Address(RVA = "0x109C220", Offset = "0x109AE20", VA = "0x18109C220")]
		public void Render(UniEquipData uniEquipData, string subProfessionId, bool isUnlockShow = false)
		{
		}

		// Token: 0x06018208 RID: 98824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018208")]
		[Address(RVA = "0x109C160", Offset = "0x109AD60", VA = "0x18109C160")]
		public void ApplyAnim()
		{
		}

		// Token: 0x06018209 RID: 98825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018209")]
		[Address(RVA = "0x109C4A0", Offset = "0x109B0A0", VA = "0x18109C4A0")]
		public void ResetAnim()
		{
		}

		// Token: 0x0601820A RID: 98826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601820A")]
		[Address(RVA = "0x109C660", Offset = "0x109B260", VA = "0x18109C660")]
		public UniEquipShowView()
		{
		}

		// Token: 0x0401D51C RID: 120092
		[Token(Token = "0x401D51C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelEquipBack;

		// Token: 0x0401D51D RID: 120093
		[Token(Token = "0x401D51D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _equipName;

		// Token: 0x0401D51E RID: 120094
		[Token(Token = "0x401D51E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _equipDesc;

		// Token: 0x0401D51F RID: 120095
		[Token(Token = "0x401D51F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AnimationWrapper _animationWrapper;

		// Token: 0x0401D520 RID: 120096
		[Token(Token = "0x401D520")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform _imgContainer;

		// Token: 0x0401D521 RID: 120097
		[Token(Token = "0x401D521")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UniEquipImgHolder _imgHolder;

		// Token: 0x0401D522 RID: 120098
		[Token(Token = "0x401D522")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Transform _typeContainer;

		// Token: 0x0401D523 RID: 120099
		[Token(Token = "0x401D523")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UICommonEquipTypeIcon _typeIcon;

		// Token: 0x0401D524 RID: 120100
		[Token(Token = "0x401D524")]
		[FieldOffset(Offset = "0x58")]
		private string NORM_ANIM;

		// Token: 0x0401D525 RID: 120101
		[Token(Token = "0x401D525")]
		[FieldOffset(Offset = "0x60")]
		private string UNLOCK_ANIM;

		// Token: 0x0401D526 RID: 120102
		[Token(Token = "0x401D526")]
		[FieldOffset(Offset = "0x68")]
		private bool m_isUnlockShow;

		// Token: 0x0401D527 RID: 120103
		[Token(Token = "0x401D527")]
		[FieldOffset(Offset = "0x69")]
		private bool m_isInited;

		// Token: 0x0401D528 RID: 120104
		[Token(Token = "0x401D528")]
		[FieldOffset(Offset = "0x70")]
		private UniEquipImgHolder m_imgHolder;

		// Token: 0x0401D529 RID: 120105
		[Token(Token = "0x401D529")]
		[FieldOffset(Offset = "0x78")]
		private UICommonEquipTypeIcon m_typeIcon;

		// Token: 0x0401D52A RID: 120106
		[Token(Token = "0x401D52A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401D52B RID: 120107
		[Token(Token = "0x401D52B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401D52C RID: 120108
		[Token(Token = "0x401D52C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ApplyAnim;

		// Token: 0x0401D52D RID: 120109
		[Token(Token = "0x401D52D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ResetAnim;

		// Token: 0x0401D52E RID: 120110
		[Token(Token = "0x401D52E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
