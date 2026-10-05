using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Torappu.UI.Home
{
	// Token: 0x02004C07 RID: 19463
	[Token(Token = "0x2004C07")]
	public class HomeDiamondChangeView : MonoBehaviour
	{
		// Token: 0x0601D3C4 RID: 119748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D3C4")]
		[Address(RVA = "0x16CA6E0", Offset = "0x16C92E0", VA = "0x1816CA6E0", Slot = "4")]
		protected virtual void Start()
		{
		}

		// Token: 0x0601D3C5 RID: 119749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D3C5")]
		[Address(RVA = "0x16CA890", Offset = "0x16C9490", VA = "0x1816CA890")]
		private void _Init()
		{
		}

		// Token: 0x0601D3C6 RID: 119750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D3C6")]
		[Address(RVA = "0x16CADD0", Offset = "0x16C99D0", VA = "0x1816CADD0")]
		private void _RefreshView()
		{
		}

		// Token: 0x0601D3C7 RID: 119751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D3C7")]
		[Address(RVA = "0x16CA4B0", Offset = "0x16C90B0", VA = "0x1816CA4B0")]
		public void Show()
		{
		}

		// Token: 0x0601D3C8 RID: 119752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D3C8")]
		[Address(RVA = "0x16CA090", Offset = "0x16C8C90", VA = "0x1816CA090")]
		public void Dismiss()
		{
		}

		// Token: 0x0601D3C9 RID: 119753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D3C9")]
		[Address(RVA = "0x16CA280", Offset = "0x16C8E80", VA = "0x1816CA280")]
		public void SendDiamondExchangeService()
		{
		}

		// Token: 0x0601D3CA RID: 119754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D3CA")]
		[Address(RVA = "0x16CABB0", Offset = "0x16C97B0", VA = "0x1816CABB0")]
		private void _OnExchangeResponseSuccess(ExchangeDiamondShardResponse response)
		{
		}

		// Token: 0x0601D3CB RID: 119755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D3CB")]
		[Address(RVA = "0x16CA080", Offset = "0x16C8C80", VA = "0x1816CA080")]
		public void Add()
		{
		}

		// Token: 0x0601D3CC RID: 119756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D3CC")]
		[Address(RVA = "0x16CA060", Offset = "0x16C8C60", VA = "0x1816CA060")]
		public void AddToMax()
		{
		}

		// Token: 0x0601D3CD RID: 119757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D3CD")]
		[Address(RVA = "0x16CA270", Offset = "0x16C8E70", VA = "0x1816CA270")]
		public void Minus()
		{
		}

		// Token: 0x0601D3CE RID: 119758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D3CE")]
		[Address(RVA = "0x16CA250", Offset = "0x16C8E50", VA = "0x1816CA250")]
		public void MinusToOne()
		{
		}

		// Token: 0x0601D3CF RID: 119759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D3CF")]
		[Address(RVA = "0x16CB220", Offset = "0x16C9E20", VA = "0x1816CB220")]
		public HomeDiamondChangeView()
		{
		}

		// Token: 0x040266C7 RID: 157383
		[Token(Token = "0x40266C7")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _diamondShCount;

		// Token: 0x040266C8 RID: 157384
		[Token(Token = "0x40266C8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _changeText;

		// Token: 0x040266C9 RID: 157385
		[Token(Token = "0x40266C9")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _exchangeCount;

		// Token: 0x040266CA RID: 157386
		[Token(Token = "0x40266CA")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _maxCount;

		// Token: 0x040266CB RID: 157387
		[Token(Token = "0x40266CB")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _exchangeResultCount;

		// Token: 0x040266CC RID: 157388
		[Token(Token = "0x40266CC")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _minus;

		// Token: 0x040266CD RID: 157389
		[Token(Token = "0x40266CD")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _minusGray;

		// Token: 0x040266CE RID: 157390
		[Token(Token = "0x40266CE")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _add;

		// Token: 0x040266CF RID: 157391
		[Token(Token = "0x40266CF")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _addGray;

		// Token: 0x040266D0 RID: 157392
		[Token(Token = "0x40266D0")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UIAnimationLocation _showAnimation;

		// Token: 0x040266D1 RID: 157393
		[Token(Token = "0x40266D1")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Transform _containerFirst;

		// Token: 0x040266D2 RID: 157394
		[Token(Token = "0x40266D2")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Transform _containerSecond;

		// Token: 0x040266D3 RID: 157395
		[Token(Token = "0x40266D3")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private float _itemScale;

		// Token: 0x040266D4 RID: 157396
		[Token(Token = "0x40266D4")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _pageContainer;

		// Token: 0x040266D5 RID: 157397
		[Token(Token = "0x40266D5")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private UnityEvent _eventBuyBuyFinish;

		// Token: 0x040266D6 RID: 157398
		[Token(Token = "0x40266D6")]
		[FieldOffset(Offset = "0x98")]
		private int m_count;

		// Token: 0x040266D7 RID: 157399
		[Token(Token = "0x40266D7")]
		[FieldOffset(Offset = "0x9C")]
		private int m_changeRate;

		// Token: 0x040266D8 RID: 157400
		[Token(Token = "0x40266D8")]
		[FieldOffset(Offset = "0xA0")]
		private int m_maxCount;

		// Token: 0x040266D9 RID: 157401
		[Token(Token = "0x40266D9")]
		[FieldOffset(Offset = "0xA8")]
		private long m_shCount;

		// Token: 0x040266DA RID: 157402
		[Token(Token = "0x40266DA")]
		[FieldOffset(Offset = "0xB0")]
		private Tween m_showTweener;

		// Token: 0x040266DB RID: 157403
		[Token(Token = "0x40266DB")]
		[FieldOffset(Offset = "0xB8")]
		private bool m_isShowing;

		// Token: 0x040266DC RID: 157404
		[Token(Token = "0x40266DC")]
		[FieldOffset(Offset = "0xC0")]
		private UIItemCard m_costItem;

		// Token: 0x040266DD RID: 157405
		[Token(Token = "0x40266DD")]
		[FieldOffset(Offset = "0xC8")]
		private UIItemCard m_targetItem;

		// Token: 0x040266DE RID: 157406
		[Token(Token = "0x40266DE")]
		[FieldOffset(Offset = "0xD0")]
		private UIItemViewModel m_costModel;

		// Token: 0x040266DF RID: 157407
		[Token(Token = "0x40266DF")]
		[FieldOffset(Offset = "0xD8")]
		private UIItemViewModel m_targetModel;

		// Token: 0x040266E0 RID: 157408
		[Token(Token = "0x40266E0")]
		[FieldOffset(Offset = "0xE0")]
		private bool m_initFlag;
	}
}
