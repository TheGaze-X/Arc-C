using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.AVG;
using UnityEngine;
using XLua;

namespace Torappu.UI.Firework.FireworkPuzzle
{
	// Token: 0x02004E5F RID: 20063
	[Token(Token = "0x2004E5F")]
	public class FireworkPuzzleMapState : State, IHotfixable, IValueMsgReceiver
	{
		// Token: 0x0601DF05 RID: 122629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DF05")]
		[Address(RVA = "0x17A9B50", Offset = "0x17A8750", VA = "0x1817A9B50", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601DF06 RID: 122630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DF06")]
		[Address(RVA = "0x17AAAB0", Offset = "0x17A96B0", VA = "0x1817AAAB0")]
		private void _TryStartTutorial()
		{
		}

		// Token: 0x0601DF07 RID: 122631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DF07")]
		[Address(RVA = "0x17AA8D0", Offset = "0x17A94D0", VA = "0x1817AA8D0")]
		private void _OpenGuideBook(Story story)
		{
		}

		// Token: 0x0601DF08 RID: 122632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DF08")]
		[Address(RVA = "0x17AA190", Offset = "0x17A8D90", VA = "0x1817AA190", Slot = "16")]
		protected override void OnPreResume(bool isFromStack)
		{
		}

		// Token: 0x0601DF09 RID: 122633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DF09")]
		[Address(RVA = "0x17AA500", Offset = "0x17A9100", VA = "0x1817AA500")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601DF0A RID: 122634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601DF0A")]
		[Address(RVA = "0x17A9AF0", Offset = "0x17A86F0", VA = "0x1817A9AF0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601DF0B RID: 122635 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601DF0B")]
		[Address(RVA = "0x17AA2E0", Offset = "0x17A8EE0", VA = "0x1817AA2E0", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0601DF0C RID: 122636 RVA: 0x000ACF98 File Offset: 0x000AB198
		[Token(Token = "0x601DF0C")]
		[Address(RVA = "0x17AA600", Offset = "0x17A9200", VA = "0x1817AA600")]
		private bool _IsUIStable()
		{
			return default(bool);
		}

		// Token: 0x0601DF0D RID: 122637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DF0D")]
		[Address(RVA = "0x17AA440", Offset = "0x17A9040", VA = "0x1817AA440")]
		private void _EventOnBack()
		{
		}

		// Token: 0x0601DF0E RID: 122638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DF0E")]
		[Address(RVA = "0x17AA960", Offset = "0x17A9560", VA = "0x1817AA960")]
		private void _RegisterToDetailState(IStateBean targetBean)
		{
		}

		// Token: 0x0601DF0F RID: 122639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DF0F")]
		[Address(RVA = "0x17AA0E0", Offset = "0x17A8CE0", VA = "0x1817AA0E0", Slot = "23")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0601DF10 RID: 122640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DF10")]
		[Address(RVA = "0x17AA6C0", Offset = "0x17A92C0", VA = "0x1817AA6C0")]
		private void _OnPuzzleClicked(string puzzleId)
		{
		}

		// Token: 0x0601DF11 RID: 122641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DF11")]
		[Address(RVA = "0x17AAC00", Offset = "0x17A9800", VA = "0x1817AAC00")]
		public FireworkPuzzleMapState()
		{
		}

		// Token: 0x0601DF12 RID: 122642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DF12")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0601DF13 RID: 122643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DF13")]
		[Address(RVA = "0x1061490", Offset = "0x1060090", VA = "0x181061490")]
		private void <>xLuaBaseProxy_OnPreResume(bool P0)
		{
		}

		// Token: 0x0601DF14 RID: 122644 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601DF14")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x04027BF2 RID: 162802
		[Token(Token = "0x4027BF2")]
		private const string GUIDE_SUB_SIGNAL = "puzzle";

		// Token: 0x04027BF3 RID: 162803
		[Token(Token = "0x4027BF3")]
		[NonSerialized]
		public const int ON_PUZZLE_CLICKED = 0;

		// Token: 0x04027BF4 RID: 162804
		[Token(Token = "0x4027BF4")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RectTransform _topMenuContainer;

		// Token: 0x04027BF5 RID: 162805
		[Token(Token = "0x4027BF5")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private FireworkPuzzleMapView _view;

		// Token: 0x04027BF6 RID: 162806
		[Token(Token = "0x4027BF6")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UIAnimationLocation _enterAnim;

		// Token: 0x04027BF7 RID: 162807
		[Token(Token = "0x4027BF7")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _btnFirstPuzzle;

		// Token: 0x04027BF8 RID: 162808
		[Token(Token = "0x4027BF8")]
		[FieldOffset(Offset = "0x78")]
		private FireworkPuzzleMapStateBean m_stateBean;

		// Token: 0x04027BF9 RID: 162809
		[Token(Token = "0x4027BF9")]
		[FieldOffset(Offset = "0x80")]
		private bool m_hasInited;

		// Token: 0x04027BFA RID: 162810
		[Token(Token = "0x4027BFA")]
		[FieldOffset(Offset = "0x88")]
		private Tween m_enterAnimTween;

		// Token: 0x04027BFB RID: 162811
		[Token(Token = "0x4027BFB")]
		[FieldOffset(Offset = "0x90")]
		private string m_cachedActId;

		// Token: 0x04027BFC RID: 162812
		[Token(Token = "0x4027BFC")]
		[FieldOffset(Offset = "0x98")]
		private List<string> m_cachedUnlockedPuzzleList;

		// Token: 0x04027BFD RID: 162813
		[Token(Token = "0x4027BFD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04027BFE RID: 162814
		[Token(Token = "0x4027BFE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__TryStartTutorial;

		// Token: 0x04027BFF RID: 162815
		[Token(Token = "0x4027BFF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OpenGuideBook;

		// Token: 0x04027C00 RID: 162816
		[Token(Token = "0x4027C00")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnPreResume;

		// Token: 0x04027C01 RID: 162817
		[Token(Token = "0x4027C01")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04027C02 RID: 162818
		[Token(Token = "0x4027C02")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04027C03 RID: 162819
		[Token(Token = "0x4027C03")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x04027C04 RID: 162820
		[Token(Token = "0x4027C04")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__IsUIStable;

		// Token: 0x04027C05 RID: 162821
		[Token(Token = "0x4027C05")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__EventOnBack;

		// Token: 0x04027C06 RID: 162822
		[Token(Token = "0x4027C06")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__RegisterToDetailState;

		// Token: 0x04027C07 RID: 162823
		[Token(Token = "0x4027C07")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x04027C08 RID: 162824
		[Token(Token = "0x4027C08")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnPuzzleClicked;

		// Token: 0x04027C09 RID: 162825
		[Token(Token = "0x4027C09")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
