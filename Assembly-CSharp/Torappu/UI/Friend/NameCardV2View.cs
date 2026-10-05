using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI.CrossAppShare;
using UnityEngine;
using UnityEngine.EventSystems;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004E1A RID: 19994
	[Token(Token = "0x2004E1A")]
	public class NameCardV2View : DataBinder<NameCardV2Property>
	{
		// Token: 0x1700460F RID: 17935
		// (set) Token: 0x0601DDEB RID: 122347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700460F")]
		public IDragHandler parentDragHandler
		{
			[Token(Token = "0x601DDEB")]
			[Address(RVA = "0x177C7C0", Offset = "0x177B3C0", VA = "0x18177C7C0")]
			set
			{
			}
		}

		// Token: 0x0601DDEC RID: 122348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DDEC")]
		[Address(RVA = "0x177AEC0", Offset = "0x1779AC0", VA = "0x18177AEC0", Slot = "7")]
		public override void OnValueChanged(NameCardV2Property property)
		{
		}

		// Token: 0x0601DDED RID: 122349 RVA: 0x000AC8D8 File Offset: 0x000AAAD8
		[Token(Token = "0x601DDED")]
		[Address(RVA = "0x177AE50", Offset = "0x1779A50", VA = "0x18177AE50")]
		public bool IsTweening()
		{
			return default(bool);
		}

		// Token: 0x0601DDEE RID: 122350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601DDEE")]
		[Address(RVA = "0x177ADE0", Offset = "0x17799E0", VA = "0x18177ADE0")]
		public Transform GetScaleHost()
		{
			return null;
		}

		// Token: 0x0601DDEF RID: 122351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DDEF")]
		[Address(RVA = "0x177B880", Offset = "0x177A480", VA = "0x18177B880")]
		public void SetScaleHost(Transform scaleHost)
		{
		}

		// Token: 0x0601DDF0 RID: 122352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DDF0")]
		[Address(RVA = "0x177B9F0", Offset = "0x177A5F0", VA = "0x18177B9F0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601DDF1 RID: 122353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DDF1")]
		[Address(RVA = "0x177BCB0", Offset = "0x177A8B0", VA = "0x18177BCB0")]
		private void _ReloadModuleObjects(List<string> selectedModuleIds)
		{
		}

		// Token: 0x0601DDF2 RID: 122354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DDF2")]
		[Address(RVA = "0x177C530", Offset = "0x177B130", VA = "0x18177C530")]
		private void _RenderAndSortSelectedModules(List<NameCardV2RemovableModuleBaseModel> models)
		{
		}

		// Token: 0x0601DDF3 RID: 122355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DDF3")]
		[Address(RVA = "0x177BFD0", Offset = "0x177ABD0", VA = "0x18177BFD0")]
		private void _RenderAndSortSelectedModulesWithTween(ListDict<string, NameCardV2RemovableModuleBaseModel> listDict)
		{
		}

		// Token: 0x0601DDF4 RID: 122356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DDF4")]
		[Address(RVA = "0x177BB90", Offset = "0x177A790", VA = "0x18177BB90")]
		private void _OnModuleHidden(string moduleId)
		{
		}

		// Token: 0x0601DDF5 RID: 122357 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601DDF5")]
		[Address(RVA = "0x177B900", Offset = "0x177A500", VA = "0x18177B900")]
		private Transform _GetFixedModuleContainer(NameCardV2ModuleType type)
		{
			return null;
		}

		// Token: 0x0601DDF6 RID: 122358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DDF6")]
		[Address(RVA = "0x177C6A0", Offset = "0x177B2A0", VA = "0x18177C6A0")]
		public NameCardV2View()
		{
		}

		// Token: 0x04027999 RID: 162201
		[Token(Token = "0x4027999")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _selectedModuleContainer;

		// Token: 0x0402799A RID: 162202
		[Token(Token = "0x402799A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _avatarViewContainer;

		// Token: 0x0402799B RID: 162203
		[Token(Token = "0x402799B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _detailViewContainer;

		// Token: 0x0402799C RID: 162204
		[Token(Token = "0x402799C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform _simpleViewContainer;

		// Token: 0x0402799D RID: 162205
		[Token(Token = "0x402799D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform _bgViewContainer;

		// Token: 0x0402799E RID: 162206
		[Token(Token = "0x402799E")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Transform _collectViewContainer;

		// Token: 0x0402799F RID: 162207
		[Token(Token = "0x402799F")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform _illustViewContainer;

		// Token: 0x040279A0 RID: 162208
		[Token(Token = "0x40279A0")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UIWrappedScrollRect _detailScrollRect;

		// Token: 0x040279A1 RID: 162209
		[Token(Token = "0x40279A1")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UIStyleProvider _styleProvider;

		// Token: 0x040279A2 RID: 162210
		[Token(Token = "0x40279A2")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UIAnimationLocation _switchDetailAnim;

		// Token: 0x040279A3 RID: 162211
		[Token(Token = "0x40279A3")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private float _duration;

		// Token: 0x040279A4 RID: 162212
		[Token(Token = "0x40279A4")]
		[FieldOffset(Offset = "0x80")]
		private Transform m_scaleHost;

		// Token: 0x040279A5 RID: 162213
		[Token(Token = "0x40279A5")]
		[FieldOffset(Offset = "0x88")]
		private ListDict<string, NameCardV2BaseModuleView> m_fixedModules;

		// Token: 0x040279A6 RID: 162214
		[Token(Token = "0x40279A6")]
		[FieldOffset(Offset = "0x90")]
		private ListDict<string, NameCardV2BaseRemovableModuleView> m_selectedModules;

		// Token: 0x040279A7 RID: 162215
		[Token(Token = "0x40279A7")]
		[FieldOffset(Offset = "0x98")]
		private bool m_hasInited;

		// Token: 0x040279A8 RID: 162216
		[Token(Token = "0x40279A8")]
		[FieldOffset(Offset = "0xA0")]
		private UIPageFinder m_pageFinder;

		// Token: 0x040279A9 RID: 162217
		[Token(Token = "0x40279A9")]
		[FieldOffset(Offset = "0xB0")]
		private int m_cachedEditSeqNum;

		// Token: 0x040279AA RID: 162218
		[Token(Token = "0x40279AA")]
		[FieldOffset(Offset = "0xB4")]
		private int m_cachedShowDetailSeqNum;

		// Token: 0x040279AB RID: 162219
		[Token(Token = "0x40279AB")]
		[FieldOffset(Offset = "0xB8")]
		private AnimationSwitchTween m_tween;

		// Token: 0x040279AC RID: 162220
		[Token(Token = "0x40279AC")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Group("Cross App Share")]
		private CrossAppShareStartLayoutContent _shareBackgroundContent;

		// Token: 0x040279AD RID: 162221
		[Token(Token = "0x40279AD")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Group("Cross App Share")]
		private CrossAppShareStartLayoutContent _shareIllustContent;

		// Token: 0x040279AE RID: 162222
		[Token(Token = "0x40279AE")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[Group("Cross App Share")]
		private CrossAppShareStartLayoutContent _shareCollectContent;

		// Token: 0x040279AF RID: 162223
		[Token(Token = "0x40279AF")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[Group("Cross App Share")]
		private CrossAppShareStartLayoutContent _shareAvatarContent;

		// Token: 0x040279B0 RID: 162224
		[Token(Token = "0x40279B0")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		[Group("Cross App Share")]
		private CrossAppShareStartLayoutContent _shareSimpleAvatarContent;

		// Token: 0x040279B1 RID: 162225
		[Token(Token = "0x40279B1")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		[Group("Cross App Share")]
		private CrossAppShareStartLayoutContent _shareRemovableContent;

		// Token: 0x040279B2 RID: 162226
		[Token(Token = "0x40279B2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_parentDragHandler;

		// Token: 0x040279B3 RID: 162227
		[Token(Token = "0x40279B3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040279B4 RID: 162228
		[Token(Token = "0x40279B4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_IsTweening;

		// Token: 0x040279B5 RID: 162229
		[Token(Token = "0x40279B5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetScaleHost;

		// Token: 0x040279B6 RID: 162230
		[Token(Token = "0x40279B6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SetScaleHost;

		// Token: 0x040279B7 RID: 162231
		[Token(Token = "0x40279B7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040279B8 RID: 162232
		[Token(Token = "0x40279B8")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ReloadModuleObjects;

		// Token: 0x040279B9 RID: 162233
		[Token(Token = "0x40279B9")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RenderAndSortSelectedModules;

		// Token: 0x040279BA RID: 162234
		[Token(Token = "0x40279BA")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__RenderAndSortSelectedModulesWithTween;

		// Token: 0x040279BB RID: 162235
		[Token(Token = "0x40279BB")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnModuleHidden;

		// Token: 0x040279BC RID: 162236
		[Token(Token = "0x40279BC")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__GetFixedModuleContainer;

		// Token: 0x040279BD RID: 162237
		[Token(Token = "0x40279BD")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004E1B RID: 19995
		[Token(Token = "0x2004E1B")]
		public class NameCardV2ModelCollector : ICrossAppShareModelCollector, IHotfixable
		{
			// Token: 0x17004610 RID: 17936
			// (get) Token: 0x0601DDF7 RID: 122359 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601DDF8 RID: 122360 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17004610")]
			public CrossAppShareLayoutContentModel bgContentModel
			{
				[Token(Token = "0x601DDF7")]
				[Address(RVA = "0x1777350", Offset = "0x1775F50", VA = "0x181777350")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x601DDF8")]
				[Address(RVA = "0x17775D0", Offset = "0x17761D0", VA = "0x1817775D0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17004611 RID: 17937
			// (get) Token: 0x0601DDF9 RID: 122361 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601DDFA RID: 122362 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17004611")]
			public CrossAppShareLayoutContentModel illustContentModel
			{
				[Token(Token = "0x601DDF9")]
				[Address(RVA = "0x1777410", Offset = "0x1776010", VA = "0x181777410")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x601DDFA")]
				[Address(RVA = "0x17776D0", Offset = "0x17762D0", VA = "0x1817776D0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17004612 RID: 17938
			// (get) Token: 0x0601DDFB RID: 122363 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601DDFC RID: 122364 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17004612")]
			public CrossAppShareLayoutContentModel collectContentModel
			{
				[Token(Token = "0x601DDFB")]
				[Address(RVA = "0x17773B0", Offset = "0x1775FB0", VA = "0x1817773B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x601DDFC")]
				[Address(RVA = "0x1777650", Offset = "0x1776250", VA = "0x181777650")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17004613 RID: 17939
			// (get) Token: 0x0601DDFD RID: 122365 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601DDFE RID: 122366 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17004613")]
			public CrossAppShareLayoutContentModel avatarContentModel
			{
				[Token(Token = "0x601DDFD")]
				[Address(RVA = "0x1777290", Offset = "0x1775E90", VA = "0x181777290")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x601DDFE")]
				[Address(RVA = "0x17774D0", Offset = "0x17760D0", VA = "0x1817774D0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17004614 RID: 17940
			// (get) Token: 0x0601DDFF RID: 122367 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601DE00 RID: 122368 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17004614")]
			public CrossAppShareLayoutContentModel avatarSimpleContentModel
			{
				[Token(Token = "0x601DDFF")]
				[Address(RVA = "0x17772F0", Offset = "0x1775EF0", VA = "0x1817772F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x601DE00")]
				[Address(RVA = "0x1777550", Offset = "0x1776150", VA = "0x181777550")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17004615 RID: 17941
			// (get) Token: 0x0601DE01 RID: 122369 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601DE02 RID: 122370 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17004615")]
			public CrossAppShareLayoutContentModel removableContentModel
			{
				[Token(Token = "0x601DE01")]
				[Address(RVA = "0x1777470", Offset = "0x1776070", VA = "0x181777470")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x601DE02")]
				[Address(RVA = "0x1777750", Offset = "0x1776350", VA = "0x181777750")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x0601DE03 RID: 122371 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DE03")]
			[Address(RVA = "0x17771B0", Offset = "0x1775DB0", VA = "0x1817771B0")]
			public void InitCollector(NameCardV2View closure)
			{
			}

			// Token: 0x0601DE04 RID: 122372 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DE04")]
			[Address(RVA = "0x1776E10", Offset = "0x1775A10", VA = "0x181776E10", Slot = "4")]
			public void CollectModel()
			{
			}

			// Token: 0x0601DE05 RID: 122373 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DE05")]
			[Address(RVA = "0x1777230", Offset = "0x1775E30", VA = "0x181777230")]
			public NameCardV2ModelCollector()
			{
			}

			// Token: 0x040279BE RID: 162238
			[Token(Token = "0x40279BE")]
			[FieldOffset(Offset = "0x10")]
			private NameCardV2View m_closure;

			// Token: 0x040279C5 RID: 162245
			[Token(Token = "0x40279C5")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_bgContentModel;

			// Token: 0x040279C6 RID: 162246
			[Token(Token = "0x40279C6")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_bgContentModel;

			// Token: 0x040279C7 RID: 162247
			[Token(Token = "0x40279C7")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_illustContentModel;

			// Token: 0x040279C8 RID: 162248
			[Token(Token = "0x40279C8")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_set_illustContentModel;

			// Token: 0x040279C9 RID: 162249
			[Token(Token = "0x40279C9")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_collectContentModel;

			// Token: 0x040279CA RID: 162250
			[Token(Token = "0x40279CA")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_set_collectContentModel;

			// Token: 0x040279CB RID: 162251
			[Token(Token = "0x40279CB")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_get_avatarContentModel;

			// Token: 0x040279CC RID: 162252
			[Token(Token = "0x40279CC")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_set_avatarContentModel;

			// Token: 0x040279CD RID: 162253
			[Token(Token = "0x40279CD")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_get_avatarSimpleContentModel;

			// Token: 0x040279CE RID: 162254
			[Token(Token = "0x40279CE")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_set_avatarSimpleContentModel;

			// Token: 0x040279CF RID: 162255
			[Token(Token = "0x40279CF")]
			[FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_get_removableContentModel;

			// Token: 0x040279D0 RID: 162256
			[Token(Token = "0x40279D0")]
			[FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0_set_removableContentModel;

			// Token: 0x040279D1 RID: 162257
			[Token(Token = "0x40279D1")]
			[FieldOffset(Offset = "0x60")]
			private static DelegateBridge __Hotfix0_InitCollector;

			// Token: 0x040279D2 RID: 162258
			[Token(Token = "0x40279D2")]
			[FieldOffset(Offset = "0x68")]
			private static DelegateBridge __Hotfix0_CollectModel;

			// Token: 0x040279D3 RID: 162259
			[Token(Token = "0x40279D3")]
			[FieldOffset(Offset = "0x70")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
