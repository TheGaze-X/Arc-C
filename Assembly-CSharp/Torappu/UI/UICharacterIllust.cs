using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003538 RID: 13624
	[Token(Token = "0x2003538")]
	public abstract class UICharacterIllust : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003395 RID: 13205
		// (get) Token: 0x06015B6E RID: 88942
		// (set) Token: 0x06015B6F RID: 88943
		[Token(Token = "0x17003395")]
		[Inspect]
		[ReadOnly]
		public abstract string illustId { [Token(Token = "0x6015B6E")] get; [Token(Token = "0x6015B6F")] protected set; }

		// Token: 0x17003396 RID: 13206
		// (get) Token: 0x06015B70 RID: 88944
		[Token(Token = "0x17003396")]
		public abstract bool isDynamic { [Token(Token = "0x6015B70")] get; }

		// Token: 0x17003397 RID: 13207
		// (get) Token: 0x06015B71 RID: 88945
		[Token(Token = "0x17003397")]
		public abstract bool isActiveIllust { [Token(Token = "0x6015B71")] get; }

		// Token: 0x17003398 RID: 13208
		// (get) Token: 0x06015B72 RID: 88946
		[Token(Token = "0x17003398")]
		public abstract RectTransform rectTransform { [Token(Token = "0x6015B72")] get; }

		// Token: 0x17003399 RID: 13209
		// (get) Token: 0x06015B73 RID: 88947
		// (set) Token: 0x06015B74 RID: 88948
		[Token(Token = "0x17003399")]
		public abstract bool raycastTarget { [Token(Token = "0x6015B73")] get; [Token(Token = "0x6015B74")] set; }

		// Token: 0x1700339A RID: 13210
		// (get) Token: 0x06015B75 RID: 88949
		// (set) Token: 0x06015B76 RID: 88950
		[Token(Token = "0x1700339A")]
		public abstract Color color { [Token(Token = "0x6015B75")] get; [Token(Token = "0x6015B76")] set; }

		// Token: 0x1700339B RID: 13211
		// (get) Token: 0x06015B77 RID: 88951
		[Token(Token = "0x1700339B")]
		public abstract float alpha { [Token(Token = "0x6015B77")] get; }

		// Token: 0x1700339C RID: 13212
		// (get) Token: 0x06015B78 RID: 88952
		[Token(Token = "0x1700339C")]
		public abstract Texture mainTexture { [Token(Token = "0x6015B78")] get; }

		// Token: 0x1700339D RID: 13213
		// (get) Token: 0x06015B79 RID: 88953
		[Token(Token = "0x1700339D")]
		public abstract Vector2 rawSize { [Token(Token = "0x6015B79")] get; }

		// Token: 0x1700339E RID: 13214
		// (get) Token: 0x06015B7A RID: 88954
		[Token(Token = "0x1700339E")]
		public abstract IList<Graphic> graphics { [Token(Token = "0x6015B7A")] get; }

		// Token: 0x1700339F RID: 13215
		// (get) Token: 0x06015B7B RID: 88955
		[Token(Token = "0x1700339F")]
		protected abstract Graphic mainGraphic { [Token(Token = "0x6015B7B")] get; }

		// Token: 0x06015B7C RID: 88956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015B7C")]
		[Address(RVA = "0xE4B3A0", Offset = "0xE49FA0", VA = "0x180E4B3A0", Slot = "18")]
		protected virtual void OnEnable()
		{
		}

		// Token: 0x06015B7D RID: 88957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015B7D")]
		[Address(RVA = "0xE4B340", Offset = "0xE49F40", VA = "0x180E4B340", Slot = "19")]
		protected virtual void OnDisable()
		{
		}

		// Token: 0x06015B7E RID: 88958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015B7E")]
		[Address(RVA = "0xE4B2E0", Offset = "0xE49EE0", VA = "0x180E4B2E0", Slot = "20")]
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x06015B7F RID: 88959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015B7F")]
		[Address(RVA = "0xE4B400", Offset = "0xE4A000", VA = "0x180E4B400", Slot = "21")]
		public virtual void OnTick()
		{
		}

		// Token: 0x06015B80 RID: 88960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015B80")]
		[Address(RVA = "0xE4B220", Offset = "0xE49E20", VA = "0x180E4B220", Slot = "22")]
		public virtual void OnActivated()
		{
		}

		// Token: 0x06015B81 RID: 88961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015B81")]
		[Address(RVA = "0xE4B280", Offset = "0xE49E80", VA = "0x180E4B280", Slot = "23")]
		public virtual void OnDeactivated()
		{
		}

		// Token: 0x06015B82 RID: 88962
		[Token(Token = "0x6015B82")]
		public abstract void Activate(bool fastMode = false);

		// Token: 0x06015B83 RID: 88963
		[Token(Token = "0x6015B83")]
		public abstract void SetAlpha(float alpha);

		// Token: 0x06015B84 RID: 88964
		[Token(Token = "0x6015B84")]
		public abstract Tween DOFade(float endValue, float duration);

		// Token: 0x06015B85 RID: 88965
		[Token(Token = "0x6015B85")]
		public abstract void ApplySkinOffset();

		// Token: 0x06015B86 RID: 88966
		[Token(Token = "0x6015B86")]
		public abstract Vector2 GetHomeSizeAdjust();

		// Token: 0x06015B87 RID: 88967
		[Token(Token = "0x6015B87")]
		public abstract float GetCharInfoSpreadPanelZoomMax();

		// Token: 0x06015B88 RID: 88968
		[Token(Token = "0x6015B88")]
		public abstract Material GetMainMaterial();

		// Token: 0x06015B89 RID: 88969
		[Token(Token = "0x6015B89")]
		public abstract void SetMainMaterial(Material mat);

		// Token: 0x06015B8A RID: 88970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015B8A")]
		[Address(RVA = "0xE4B580", Offset = "0xE4A180", VA = "0x180E4B580", Slot = "32")]
		public virtual void SetConfig(UICharacterIllust.Config config)
		{
		}

		// Token: 0x06015B8B RID: 88971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015B8B")]
		[Address(RVA = "0xE4B460", Offset = "0xE4A060", VA = "0x180E4B460", Slot = "33")]
		public virtual void PlayInteraction([Optional] string actionId)
		{
		}

		// Token: 0x06015B8C RID: 88972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015B8C")]
		[Address(RVA = "0xE4B4C0", Offset = "0xE4A0C0", VA = "0x180E4B4C0", Slot = "34")]
		public virtual void PlaySpecial()
		{
		}

		// Token: 0x06015B8D RID: 88973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015B8D")]
		[Address(RVA = "0xE4B520", Offset = "0xE4A120", VA = "0x180E4B520", Slot = "35")]
		public virtual void PlayStart()
		{
		}

		// Token: 0x06015B8E RID: 88974 RVA: 0x0008D9C0 File Offset: 0x0008BBC0
		[Token(Token = "0x6015B8E")]
		[Address(RVA = "0xE4B160", Offset = "0xE49D60", VA = "0x180E4B160", Slot = "36")]
		public virtual bool IsPlayingInteraction()
		{
			return default(bool);
		}

		// Token: 0x06015B8F RID: 88975 RVA: 0x0008D9D8 File Offset: 0x0008BBD8
		[Token(Token = "0x6015B8F")]
		[Address(RVA = "0xE4B1C0", Offset = "0xE49DC0", VA = "0x180E4B1C0", Slot = "37")]
		public virtual bool IsPlayingStart()
		{
			return default(bool);
		}

		// Token: 0x06015B90 RID: 88976 RVA: 0x0008D9F0 File Offset: 0x0008BBF0
		[Token(Token = "0x6015B90")]
		[Address(RVA = "0xE4B100", Offset = "0xE49D00", VA = "0x180E4B100", Slot = "38")]
		public virtual DynIllustAction GetDynIllustInstancePlayingActionType()
		{
			return DynIllustAction.IDLE;
		}

		// Token: 0x06015B91 RID: 88977 RVA: 0x0008DA08 File Offset: 0x0008BC08
		[Token(Token = "0x6015B91")]
		[Address(RVA = "0xE4F340", Offset = "0xE4DF40", VA = "0x180E4F340")]
		public bool CheckContextValid()
		{
			return default(bool);
		}

		// Token: 0x06015B92 RID: 88978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015B92")]
		[Address(RVA = "0xE4F3C0", Offset = "0xE4DFC0", VA = "0x180E4F3C0")]
		protected UICharacterIllust()
		{
		}

		// Token: 0x0401A16D RID: 106861
		[Token(Token = "0x401A16D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0401A16E RID: 106862
		[Token(Token = "0x401A16E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0401A16F RID: 106863
		[Token(Token = "0x401A16F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnDisable;

		// Token: 0x0401A170 RID: 106864
		[Token(Token = "0x401A170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0401A171 RID: 106865
		[Token(Token = "0x401A171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0401A172 RID: 106866
		[Token(Token = "0x401A172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnActivated;

		// Token: 0x0401A173 RID: 106867
		[Token(Token = "0x401A173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnDeactivated;

		// Token: 0x0401A174 RID: 106868
		[Token(Token = "0x401A174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SetConfig;

		// Token: 0x0401A175 RID: 106869
		[Token(Token = "0x401A175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_PlayInteraction;

		// Token: 0x0401A176 RID: 106870
		[Token(Token = "0x401A176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_PlaySpecial;

		// Token: 0x0401A177 RID: 106871
		[Token(Token = "0x401A177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_PlayStart;

		// Token: 0x0401A178 RID: 106872
		[Token(Token = "0x401A178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_IsPlayingInteraction;

		// Token: 0x0401A179 RID: 106873
		[Token(Token = "0x401A179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_IsPlayingStart;

		// Token: 0x0401A17A RID: 106874
		[Token(Token = "0x401A17A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_GetDynIllustInstancePlayingActionType;

		// Token: 0x0401A17B RID: 106875
		[Token(Token = "0x401A17B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_CheckContextValid;

		// Token: 0x0401A17C RID: 106876
		[Token(Token = "0x401A17C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003539 RID: 13625
		[Token(Token = "0x2003539")]
		public struct Config
		{
			// Token: 0x0401A17D RID: 106877
			[Token(Token = "0x401A17D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool autoIdleSpecialDisable;

			// Token: 0x0401A17E RID: 106878
			[Token(Token = "0x401A17E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Action onClick;
		}
	}
}
