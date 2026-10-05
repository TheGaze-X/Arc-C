using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x02004502 RID: 17666
	[Token(Token = "0x2004502")]
	public abstract class RoguelikeCommonOuterBuffNodeBase : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003FFF RID: 16383
		// (get) Token: 0x0601AF4F RID: 110415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003FFF")]
		public List<RoguelikeCommonOuterBuffNodeSocket> sockets
		{
			[Token(Token = "0x601AF4F")]
			[Address(RVA = "0x141E580", Offset = "0x141D180", VA = "0x18141E580")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004000 RID: 16384
		// (get) Token: 0x0601AF50 RID: 110416 RVA: 0x000A3BA8 File Offset: 0x000A1DA8
		// (set) Token: 0x0601AF51 RID: 110417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004000")]
		public float socketDelay
		{
			[Token(Token = "0x601AF50")]
			[Address(RVA = "0x141E520", Offset = "0x141D120", VA = "0x18141E520")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x601AF51")]
			[Address(RVA = "0x141E660", Offset = "0x141D260", VA = "0x18141E660")]
			set
			{
			}
		}

		// Token: 0x17004001 RID: 16385
		// (get) Token: 0x0601AF52 RID: 110418 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601AF53 RID: 110419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004001")]
		public string buffId
		{
			[Token(Token = "0x601AF52")]
			[Address(RVA = "0x141E4C0", Offset = "0x141D0C0", VA = "0x18141E4C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x601AF53")]
			[Address(RVA = "0x141E5E0", Offset = "0x141D1E0", VA = "0x18141E5E0")]
			set
			{
			}
		}

		// Token: 0x0601AF54 RID: 110420
		[Token(Token = "0x601AF54")]
		public new abstract RoguelikeCommonOuterBuffViewType GetType();

		// Token: 0x0601AF55 RID: 110421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AF55")]
		[Address(RVA = "0x141DEC0", Offset = "0x141CAC0", VA = "0x18141DEC0")]
		public void Init(RoguelikeCommonOuterBuffNodeBaseViewModel model)
		{
		}

		// Token: 0x0601AF56 RID: 110422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AF56")]
		[Address(RVA = "0x141E210", Offset = "0x141CE10", VA = "0x18141E210")]
		public void Render(string selectedBuffId, RoguelikeCommonOuterBuffNodeBaseViewModel model)
		{
		}

		// Token: 0x0601AF57 RID: 110423
		[Token(Token = "0x601AF57")]
		protected abstract void OnInit(RoguelikeCommonOuterBuffNodeBaseViewModel model);

		// Token: 0x0601AF58 RID: 110424
		[Token(Token = "0x601AF58")]
		protected abstract void OnRender(string selectedBuffId, RoguelikeCommonOuterBuffNodeBaseViewModel model);

		// Token: 0x0601AF59 RID: 110425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AF59")]
		[Address(RVA = "0x141DBA0", Offset = "0x141C7A0", VA = "0x18141DBA0")]
		protected void InitIcon(RoguelikeCommonOuterBuffNodeBaseViewModel model)
		{
		}

		// Token: 0x0601AF5A RID: 110426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AF5A")]
		[Address(RVA = "0x141DD80", Offset = "0x141C980", VA = "0x18141DD80")]
		protected void InitSocket(int index, bool isActive)
		{
		}

		// Token: 0x0601AF5B RID: 110427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AF5B")]
		[Address(RVA = "0x141E0D0", Offset = "0x141CCD0", VA = "0x18141E0D0")]
		protected void RenderSocket(int index, bool isActive, float delay)
		{
		}

		// Token: 0x0601AF5C RID: 110428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AF5C")]
		[Address(RVA = "0x141E3B0", Offset = "0x141CFB0", VA = "0x18141E3B0")]
		protected RoguelikeCommonOuterBuffNodeBase()
		{
		}

		// Token: 0x0402297A RID: 141690
		[Token(Token = "0x402297A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _activeIconImage;

		// Token: 0x0402297B RID: 141691
		[Token(Token = "0x402297B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _inactiveIconImage;

		// Token: 0x0402297C RID: 141692
		[Token(Token = "0x402297C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<RoguelikeCommonOuterBuffNodeSocket> _sockets;

		// Token: 0x0402297D RID: 141693
		[Token(Token = "0x402297D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _socketDelay;

		// Token: 0x0402297E RID: 141694
		[Token(Token = "0x402297E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private string _buffId;

		// Token: 0x0402297F RID: 141695
		[Token(Token = "0x402297F")]
		[FieldOffset(Offset = "0x40")]
		[NonSerialized]
		public Action<string> onNodeClick;

		// Token: 0x04022980 RID: 141696
		[Token(Token = "0x4022980")]
		[FieldOffset(Offset = "0x48")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04022981 RID: 141697
		[Token(Token = "0x4022981")]
		[FieldOffset(Offset = "0x58")]
		private List<IRoguelikeCommonOuterBuffNodePlugin> m_plugins;

		// Token: 0x04022982 RID: 141698
		[Token(Token = "0x4022982")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_sockets;

		// Token: 0x04022983 RID: 141699
		[Token(Token = "0x4022983")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_socketDelay;

		// Token: 0x04022984 RID: 141700
		[Token(Token = "0x4022984")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_socketDelay;

		// Token: 0x04022985 RID: 141701
		[Token(Token = "0x4022985")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_buffId;

		// Token: 0x04022986 RID: 141702
		[Token(Token = "0x4022986")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_buffId;

		// Token: 0x04022987 RID: 141703
		[Token(Token = "0x4022987")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04022988 RID: 141704
		[Token(Token = "0x4022988")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04022989 RID: 141705
		[Token(Token = "0x4022989")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_InitIcon;

		// Token: 0x0402298A RID: 141706
		[Token(Token = "0x402298A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_InitSocket;

		// Token: 0x0402298B RID: 141707
		[Token(Token = "0x402298B")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_RenderSocket;

		// Token: 0x0402298C RID: 141708
		[Token(Token = "0x402298C")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
