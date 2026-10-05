using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200352F RID: 13615
	[Token(Token = "0x200352F")]
	public class UICharacterDynIllust : UICharacterIllust
	{
		// Token: 0x17003387 RID: 13191
		// (get) Token: 0x06015B13 RID: 88851 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06015B14 RID: 88852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003387")]
		public override string illustId
		{
			[Token(Token = "0x6015B13")]
			[Address(RVA = "0xE4C5A0", Offset = "0xE4B1A0", VA = "0x180E4C5A0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6015B14")]
			[Address(RVA = "0xE4CAC0", Offset = "0xE4B6C0", VA = "0x180E4CAC0", Slot = "5")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17003388 RID: 13192
		// (get) Token: 0x06015B15 RID: 88853 RVA: 0x0008D798 File Offset: 0x0008B998
		[Token(Token = "0x17003388")]
		public override bool isDynamic
		{
			[Token(Token = "0x6015B15")]
			[Address(RVA = "0xE4C670", Offset = "0xE4B270", VA = "0x180E4C670", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003389 RID: 13193
		// (get) Token: 0x06015B16 RID: 88854 RVA: 0x0008D7B0 File Offset: 0x0008B9B0
		[Token(Token = "0x17003389")]
		public override bool isActiveIllust
		{
			[Token(Token = "0x6015B16")]
			[Address(RVA = "0xE4C600", Offset = "0xE4B200", VA = "0x180E4C600", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700338A RID: 13194
		// (get) Token: 0x06015B17 RID: 88855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700338A")]
		public override RectTransform rectTransform
		{
			[Token(Token = "0x6015B17")]
			[Address(RVA = "0xE4C990", Offset = "0xE4B590", VA = "0x180E4C990", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700338B RID: 13195
		// (get) Token: 0x06015B18 RID: 88856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700338B")]
		protected override Graphic mainGraphic
		{
			[Token(Token = "0x6015B18")]
			[Address(RVA = "0xE4C6D0", Offset = "0xE4B2D0", VA = "0x180E4C6D0", Slot = "17")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700338C RID: 13196
		// (get) Token: 0x06015B19 RID: 88857 RVA: 0x0008D7C8 File Offset: 0x0008B9C8
		// (set) Token: 0x06015B1A RID: 88858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700338C")]
		public override bool raycastTarget
		{
			[Token(Token = "0x6015B19")]
			[Address(RVA = "0xE4C8E0", Offset = "0xE4B4E0", VA = "0x180E4C8E0", Slot = "9")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6015B1A")]
			[Address(RVA = "0xE4CB40", Offset = "0xE4B740", VA = "0x180E4CB40", Slot = "10")]
			set
			{
			}
		}

		// Token: 0x1700338D RID: 13197
		// (get) Token: 0x06015B1B RID: 88859 RVA: 0x0008D7E0 File Offset: 0x0008B9E0
		// (set) Token: 0x06015B1C RID: 88860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700338D")]
		public override Color color
		{
			[Token(Token = "0x6015B1B")]
			[Address(RVA = "0xE4C3E0", Offset = "0xE4AFE0", VA = "0x180E4C3E0", Slot = "11")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6015B1C")]
			[Address(RVA = "0xE4CA00", Offset = "0xE4B600", VA = "0x180E4CA00", Slot = "12")]
			set
			{
			}
		}

		// Token: 0x1700338E RID: 13198
		// (get) Token: 0x06015B1D RID: 88861 RVA: 0x0008D7F8 File Offset: 0x0008B9F8
		[Token(Token = "0x1700338E")]
		public override float alpha
		{
			[Token(Token = "0x6015B1D")]
			[Address(RVA = "0xE4C350", Offset = "0xE4AF50", VA = "0x180E4C350", Slot = "13")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700338F RID: 13199
		// (get) Token: 0x06015B1E RID: 88862 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700338F")]
		public override Texture mainTexture
		{
			[Token(Token = "0x6015B1E")]
			[Address(RVA = "0xE4C740", Offset = "0xE4B340", VA = "0x180E4C740", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003390 RID: 13200
		// (get) Token: 0x06015B1F RID: 88863 RVA: 0x0008D810 File Offset: 0x0008BA10
		[Token(Token = "0x17003390")]
		public override Vector2 rawSize
		{
			[Token(Token = "0x6015B1F")]
			[Address(RVA = "0xE4C7D0", Offset = "0xE4B3D0", VA = "0x180E4C7D0", Slot = "15")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x17003391 RID: 13201
		// (get) Token: 0x06015B20 RID: 88864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003391")]
		public override IList<Graphic> graphics
		{
			[Token(Token = "0x6015B20")]
			[Address(RVA = "0xE4C490", Offset = "0xE4B090", VA = "0x180E4C490", Slot = "16")]
			get
			{
				return null;
			}
		}

		// Token: 0x06015B21 RID: 88865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015B21")]
		[Address(RVA = "0xE4A880", Offset = "0xE49480", VA = "0x180E4A880", Slot = "18")]
		protected override void OnEnable()
		{
		}

		// Token: 0x06015B22 RID: 88866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015B22")]
		[Address(RVA = "0xE4A7D0", Offset = "0xE493D0", VA = "0x180E4A7D0", Slot = "19")]
		protected override void OnDisable()
		{
		}

		// Token: 0x06015B23 RID: 88867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015B23")]
		[Address(RVA = "0xE4A720", Offset = "0xE49320", VA = "0x180E4A720", Slot = "20")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06015B24 RID: 88868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015B24")]
		[Address(RVA = "0xE4A930", Offset = "0xE49530", VA = "0x180E4A930", Slot = "21")]
		public override void OnTick()
		{
		}

		// Token: 0x06015B25 RID: 88869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015B25")]
		[Address(RVA = "0xE4A640", Offset = "0xE49240", VA = "0x180E4A640", Slot = "22")]
		public override void OnActivated()
		{
		}

		// Token: 0x06015B26 RID: 88870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015B26")]
		[Address(RVA = "0xE4A6C0", Offset = "0xE492C0", VA = "0x180E4A6C0", Slot = "23")]
		public override void OnDeactivated()
		{
		}

		// Token: 0x06015B27 RID: 88871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015B27")]
		[Address(RVA = "0xE4A490", Offset = "0xE49090", VA = "0x180E4A490")]
		public void Init(UICharacterIllustController.IllustHandler handler, string illustId, DynIllustView dynamicIllust)
		{
		}

		// Token: 0x06015B28 RID: 88872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015B28")]
		[Address(RVA = "0xE4A2C0", Offset = "0xE48EC0", VA = "0x180E4A2C0")]
		public DynIllustView GetDynIllustView()
		{
			return null;
		}

		// Token: 0x06015B29 RID: 88873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015B29")]
		[Address(RVA = "0xE4B090", Offset = "0xE49C90", VA = "0x180E4B090")]
		private void _EventOnClickEvent()
		{
		}

		// Token: 0x06015B2A RID: 88874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015B2A")]
		[Address(RVA = "0xE49FD0", Offset = "0xE48BD0", VA = "0x180E49FD0", Slot = "24")]
		public override void Activate(bool fastMode = false)
		{
		}

		// Token: 0x06015B2B RID: 88875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015B2B")]
		[Address(RVA = "0xE4AD60", Offset = "0xE49960", VA = "0x180E4AD60", Slot = "25")]
		public override void SetAlpha(float alpha)
		{
		}

		// Token: 0x06015B2C RID: 88876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015B2C")]
		[Address(RVA = "0xE4A0D0", Offset = "0xE48CD0", VA = "0x180E4A0D0", Slot = "26")]
		public override Tween DOFade(float endValue, float duration)
		{
			return null;
		}

		// Token: 0x06015B2D RID: 88877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015B2D")]
		[Address(RVA = "0xE4A060", Offset = "0xE48C60", VA = "0x180E4A060", Slot = "27")]
		public override void ApplySkinOffset()
		{
		}

		// Token: 0x06015B2E RID: 88878 RVA: 0x0008D828 File Offset: 0x0008BA28
		[Token(Token = "0x6015B2E")]
		[Address(RVA = "0xE4A320", Offset = "0xE48F20", VA = "0x180E4A320", Slot = "28")]
		public override Vector2 GetHomeSizeAdjust()
		{
			return default(Vector2);
		}

		// Token: 0x06015B2F RID: 88879 RVA: 0x0008D840 File Offset: 0x0008BA40
		[Token(Token = "0x6015B2F")]
		[Address(RVA = "0xE4A1D0", Offset = "0xE48DD0", VA = "0x180E4A1D0", Slot = "29")]
		public override float GetCharInfoSpreadPanelZoomMax()
		{
			return 0f;
		}

		// Token: 0x06015B30 RID: 88880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015B30")]
		[Address(RVA = "0xE4A990", Offset = "0xE49590", VA = "0x180E4A990", Slot = "33")]
		public override void PlayInteraction([Optional] string actionId)
		{
		}

		// Token: 0x06015B31 RID: 88881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015B31")]
		[Address(RVA = "0xE4AAD0", Offset = "0xE496D0", VA = "0x180E4AAD0", Slot = "34")]
		public override void PlaySpecial()
		{
		}

		// Token: 0x06015B32 RID: 88882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015B32")]
		[Address(RVA = "0xE4AC30", Offset = "0xE49830", VA = "0x180E4AC30", Slot = "35")]
		public override void PlayStart()
		{
		}

		// Token: 0x06015B33 RID: 88883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015B33")]
		[Address(RVA = "0xE4ADF0", Offset = "0xE499F0", VA = "0x180E4ADF0", Slot = "32")]
		public override void SetConfig(UICharacterIllust.Config config)
		{
		}

		// Token: 0x06015B34 RID: 88884 RVA: 0x0008D858 File Offset: 0x0008BA58
		[Token(Token = "0x6015B34")]
		[Address(RVA = "0xE4A580", Offset = "0xE49180", VA = "0x180E4A580", Slot = "36")]
		public override bool IsPlayingInteraction()
		{
			return default(bool);
		}

		// Token: 0x06015B35 RID: 88885 RVA: 0x0008D870 File Offset: 0x0008BA70
		[Token(Token = "0x6015B35")]
		[Address(RVA = "0xE4A5E0", Offset = "0xE491E0", VA = "0x180E4A5E0", Slot = "37")]
		public override bool IsPlayingStart()
		{
			return default(bool);
		}

		// Token: 0x06015B36 RID: 88886 RVA: 0x0008D888 File Offset: 0x0008BA88
		[Token(Token = "0x6015B36")]
		[Address(RVA = "0xE4A230", Offset = "0xE48E30", VA = "0x180E4A230", Slot = "38")]
		public override DynIllustAction GetDynIllustInstancePlayingActionType()
		{
			return DynIllustAction.IDLE;
		}

		// Token: 0x06015B37 RID: 88887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015B37")]
		[Address(RVA = "0xE4A3F0", Offset = "0xE48FF0", VA = "0x180E4A3F0", Slot = "30")]
		public override Material GetMainMaterial()
		{
			return null;
		}

		// Token: 0x06015B38 RID: 88888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015B38")]
		[Address(RVA = "0xE4B030", Offset = "0xE49C30", VA = "0x180E4B030", Slot = "31")]
		public override void SetMainMaterial(Material mat)
		{
		}

		// Token: 0x06015B39 RID: 88889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015B39")]
		[Address(RVA = "0xE4BE40", Offset = "0xE4AA40", VA = "0x180E4BE40")]
		private void _UpdateState()
		{
		}

		// Token: 0x06015B3A RID: 88890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015B3A")]
		[Address(RVA = "0xE4B5F0", Offset = "0xE4A1F0", VA = "0x180E4B5F0")]
		private void _ChangeState(UICharacterDynIllust.State state)
		{
		}

		// Token: 0x06015B3B RID: 88891 RVA: 0x0008D8A0 File Offset: 0x0008BAA0
		[Token(Token = "0x6015B3B")]
		[Address(RVA = "0xE4B6C0", Offset = "0xE4A2C0", VA = "0x180E4B6C0")]
		private bool _EnsureViewInst()
		{
			return default(bool);
		}

		// Token: 0x06015B3C RID: 88892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015B3C")]
		[Address(RVA = "0xE4B930", Offset = "0xE4A530", VA = "0x180E4B930")]
		private void _ResetSpecialIdleTimer(UICharacterDynIllust.SPActionType actionType)
		{
		}

		// Token: 0x06015B3D RID: 88893 RVA: 0x0008D8B8 File Offset: 0x0008BAB8
		[Token(Token = "0x6015B3D")]
		[Address(RVA = "0xE4BC50", Offset = "0xE4A850", VA = "0x180E4BC50")]
		private static KeyValuePair<int, int> _UniformSPActionTime(KeyValuePair<int, int> timeRange, DynIllustBase illust)
		{
			return default(KeyValuePair<int, int>);
		}

		// Token: 0x06015B3E RID: 88894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015B3E")]
		[Address(RVA = "0xE4B7F0", Offset = "0xE4A3F0", VA = "0x180E4B7F0")]
		private void _OnActionJustActivated(DynIllustAction curAction)
		{
		}

		// Token: 0x06015B3F RID: 88895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015B3F")]
		[Address(RVA = "0xE4B790", Offset = "0xE4A390", VA = "0x180E4B790")]
		private void _OnActionInteract()
		{
		}

		// Token: 0x06015B40 RID: 88896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015B40")]
		[Address(RVA = "0xE4B870", Offset = "0xE4A470", VA = "0x180E4B870")]
		private void _OnActionSpecialIdle()
		{
		}

		// Token: 0x06015B41 RID: 88897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015B41")]
		[Address(RVA = "0xE4B8D0", Offset = "0xE4A4D0", VA = "0x180E4B8D0")]
		private void _OnActionStart()
		{
		}

		// Token: 0x06015B42 RID: 88898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015B42")]
		[Address(RVA = "0xE4C1C0", Offset = "0xE4ADC0", VA = "0x180E4C1C0")]
		public UICharacterDynIllust()
		{
		}

		// Token: 0x06015B44 RID: 88900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015B44")]
		[Address(RVA = "0xE4B3A0", Offset = "0xE49FA0", VA = "0x180E4B3A0")]
		private void <>xLuaBaseProxy_OnEnable()
		{
		}

		// Token: 0x06015B45 RID: 88901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015B45")]
		[Address(RVA = "0xE4B340", Offset = "0xE49F40", VA = "0x180E4B340")]
		private void <>xLuaBaseProxy_OnDisable()
		{
		}

		// Token: 0x06015B46 RID: 88902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015B46")]
		[Address(RVA = "0xE4B2E0", Offset = "0xE49EE0", VA = "0x180E4B2E0")]
		private void <>xLuaBaseProxy_OnDestroy()
		{
		}

		// Token: 0x06015B47 RID: 88903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015B47")]
		[Address(RVA = "0xE4B400", Offset = "0xE4A000", VA = "0x180E4B400")]
		private void <>xLuaBaseProxy_OnTick()
		{
		}

		// Token: 0x06015B48 RID: 88904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015B48")]
		[Address(RVA = "0xE4B220", Offset = "0xE49E20", VA = "0x180E4B220")]
		private void <>xLuaBaseProxy_OnActivated()
		{
		}

		// Token: 0x06015B49 RID: 88905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015B49")]
		[Address(RVA = "0xE4B280", Offset = "0xE49E80", VA = "0x180E4B280")]
		private void <>xLuaBaseProxy_OnDeactivated()
		{
		}

		// Token: 0x06015B4A RID: 88906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015B4A")]
		[Address(RVA = "0xE4B460", Offset = "0xE4A060", VA = "0x180E4B460")]
		private void <>xLuaBaseProxy_PlayInteraction(string P0)
		{
		}

		// Token: 0x06015B4B RID: 88907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015B4B")]
		[Address(RVA = "0xE4B4C0", Offset = "0xE4A0C0", VA = "0x180E4B4C0")]
		private void <>xLuaBaseProxy_PlaySpecial()
		{
		}

		// Token: 0x06015B4C RID: 88908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015B4C")]
		[Address(RVA = "0xE4B520", Offset = "0xE4A120", VA = "0x180E4B520")]
		private void <>xLuaBaseProxy_PlayStart()
		{
		}

		// Token: 0x06015B4D RID: 88909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015B4D")]
		[Address(RVA = "0xE4B580", Offset = "0xE4A180", VA = "0x180E4B580")]
		private void <>xLuaBaseProxy_SetConfig(UICharacterIllust.Config P0)
		{
		}

		// Token: 0x06015B4E RID: 88910 RVA: 0x0008D8D0 File Offset: 0x0008BAD0
		[Token(Token = "0x6015B4E")]
		[Address(RVA = "0xE4B160", Offset = "0xE49D60", VA = "0x180E4B160")]
		private bool <>xLuaBaseProxy_IsPlayingInteraction()
		{
			return default(bool);
		}

		// Token: 0x06015B4F RID: 88911 RVA: 0x0008D8E8 File Offset: 0x0008BAE8
		[Token(Token = "0x6015B4F")]
		[Address(RVA = "0xE4B1C0", Offset = "0xE49DC0", VA = "0x180E4B1C0")]
		private bool <>xLuaBaseProxy_IsPlayingStart()
		{
			return default(bool);
		}

		// Token: 0x06015B50 RID: 88912 RVA: 0x0008D900 File Offset: 0x0008BB00
		[Token(Token = "0x6015B50")]
		[Address(RVA = "0xE4B100", Offset = "0xE49D00", VA = "0x180E4B100")]
		private DynIllustAction <>xLuaBaseProxy_GetDynIllustInstancePlayingActionType()
		{
			return DynIllustAction.IDLE;
		}

		// Token: 0x0401A0EF RID: 106735
		[Token(Token = "0x401A0EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float CHAR_INFO_SPREAD_PANEL_ZOOM_MAX;

		// Token: 0x0401A0F0 RID: 106736
		[Token(Token = "0x401A0F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float DYN_ILLUST_INIT_SECONDS;

		// Token: 0x0401A0F1 RID: 106737
		[Token(Token = "0x401A0F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ListDict<UICharacterDynIllust.SPActionType, KeyValuePair<int, int>> SP_IDLE_TIME;

		// Token: 0x0401A0F2 RID: 106738
		[Token(Token = "0x401A0F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private UICharacterIllustController.IllustHandler m_handler;

		// Token: 0x0401A0F3 RID: 106739
		[Token(Token = "0x401A0F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Tweener m_fadeTweener;

		// Token: 0x0401A0F4 RID: 106740
		[Token(Token = "0x401A0F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private DynIllustView m_view;

		// Token: 0x0401A0F5 RID: 106741
		[Token(Token = "0x401A0F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private UICharacterDynIllust.State m_state;

		// Token: 0x0401A0F6 RID: 106742
		[Token(Token = "0x401A0F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private UICharacterDynIllust.ActionTimer m_spIdleTimer;

		// Token: 0x0401A0F7 RID: 106743
		[Token(Token = "0x401A0F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private EventTrigger m_onClickTrigger;

		// Token: 0x0401A0F8 RID: 106744
		[Token(Token = "0x401A0F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Action m_onClick;

		// Token: 0x0401A0F9 RID: 106745
		[Token(Token = "0x401A0F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private UICharacterIllust.Config m_config;

		// Token: 0x0401A0FA RID: 106746
		[Token(Token = "0x401A0FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Graphic[] m_graphicArray;

		// Token: 0x0401A0FC RID: 106748
		[Token(Token = "0x401A0FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_illustId;

		// Token: 0x0401A0FD RID: 106749
		[Token(Token = "0x401A0FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_illustId;

		// Token: 0x0401A0FE RID: 106750
		[Token(Token = "0x401A0FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isDynamic;

		// Token: 0x0401A0FF RID: 106751
		[Token(Token = "0x401A0FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_isActiveIllust;

		// Token: 0x0401A100 RID: 106752
		[Token(Token = "0x401A100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_rectTransform;

		// Token: 0x0401A101 RID: 106753
		[Token(Token = "0x401A101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_mainGraphic;

		// Token: 0x0401A102 RID: 106754
		[Token(Token = "0x401A102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_raycastTarget;

		// Token: 0x0401A103 RID: 106755
		[Token(Token = "0x401A103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_raycastTarget;

		// Token: 0x0401A104 RID: 106756
		[Token(Token = "0x401A104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_color;

		// Token: 0x0401A105 RID: 106757
		[Token(Token = "0x401A105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_color;

		// Token: 0x0401A106 RID: 106758
		[Token(Token = "0x401A106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_alpha;

		// Token: 0x0401A107 RID: 106759
		[Token(Token = "0x401A107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_mainTexture;

		// Token: 0x0401A108 RID: 106760
		[Token(Token = "0x401A108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_rawSize;

		// Token: 0x0401A109 RID: 106761
		[Token(Token = "0x401A109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_graphics;

		// Token: 0x0401A10A RID: 106762
		[Token(Token = "0x401A10A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0401A10B RID: 106763
		[Token(Token = "0x401A10B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_OnDisable;

		// Token: 0x0401A10C RID: 106764
		[Token(Token = "0x401A10C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0401A10D RID: 106765
		[Token(Token = "0x401A10D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0401A10E RID: 106766
		[Token(Token = "0x401A10E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_OnActivated;

		// Token: 0x0401A10F RID: 106767
		[Token(Token = "0x401A10F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_OnDeactivated;

		// Token: 0x0401A110 RID: 106768
		[Token(Token = "0x401A110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0401A111 RID: 106769
		[Token(Token = "0x401A111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_GetDynIllustView;

		// Token: 0x0401A112 RID: 106770
		[Token(Token = "0x401A112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__EventOnClickEvent;

		// Token: 0x0401A113 RID: 106771
		[Token(Token = "0x401A113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_Activate;

		// Token: 0x0401A114 RID: 106772
		[Token(Token = "0x401A114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_SetAlpha;

		// Token: 0x0401A115 RID: 106773
		[Token(Token = "0x401A115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_DOFade;

		// Token: 0x0401A116 RID: 106774
		[Token(Token = "0x401A116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_ApplySkinOffset;

		// Token: 0x0401A117 RID: 106775
		[Token(Token = "0x401A117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_GetHomeSizeAdjust;

		// Token: 0x0401A118 RID: 106776
		[Token(Token = "0x401A118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_GetCharInfoSpreadPanelZoomMax;

		// Token: 0x0401A119 RID: 106777
		[Token(Token = "0x401A119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_PlayInteraction;

		// Token: 0x0401A11A RID: 106778
		[Token(Token = "0x401A11A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_PlaySpecial;

		// Token: 0x0401A11B RID: 106779
		[Token(Token = "0x401A11B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_PlayStart;

		// Token: 0x0401A11C RID: 106780
		[Token(Token = "0x401A11C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_SetConfig;

		// Token: 0x0401A11D RID: 106781
		[Token(Token = "0x401A11D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_IsPlayingInteraction;

		// Token: 0x0401A11E RID: 106782
		[Token(Token = "0x401A11E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_IsPlayingStart;

		// Token: 0x0401A11F RID: 106783
		[Token(Token = "0x401A11F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_GetDynIllustInstancePlayingActionType;

		// Token: 0x0401A120 RID: 106784
		[Token(Token = "0x401A120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_GetMainMaterial;

		// Token: 0x0401A121 RID: 106785
		[Token(Token = "0x401A121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_SetMainMaterial;

		// Token: 0x0401A122 RID: 106786
		[Token(Token = "0x401A122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0__UpdateState;

		// Token: 0x0401A123 RID: 106787
		[Token(Token = "0x401A123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0__ChangeState;

		// Token: 0x0401A124 RID: 106788
		[Token(Token = "0x401A124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0__EnsureViewInst;

		// Token: 0x0401A125 RID: 106789
		[Token(Token = "0x401A125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0__ResetSpecialIdleTimer;

		// Token: 0x0401A126 RID: 106790
		[Token(Token = "0x401A126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0__UniformSPActionTime;

		// Token: 0x0401A127 RID: 106791
		[Token(Token = "0x401A127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0__OnActionJustActivated;

		// Token: 0x0401A128 RID: 106792
		[Token(Token = "0x401A128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0__OnActionInteract;

		// Token: 0x0401A129 RID: 106793
		[Token(Token = "0x401A129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0__OnActionSpecialIdle;

		// Token: 0x0401A12A RID: 106794
		[Token(Token = "0x401A12A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0__OnActionStart;

		// Token: 0x0401A12B RID: 106795
		[Token(Token = "0x401A12B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003530 RID: 13616
		[Token(Token = "0x2003530")]
		private enum State
		{
			// Token: 0x0401A12D RID: 106797
			[Token(Token = "0x401A12D")]
			DEACTIVATED,
			// Token: 0x0401A12E RID: 106798
			[Token(Token = "0x401A12E")]
			JUST_ACTIVATED,
			// Token: 0x0401A12F RID: 106799
			[Token(Token = "0x401A12F")]
			IDLE,
			// Token: 0x0401A130 RID: 106800
			[Token(Token = "0x401A130")]
			INTERACTION,
			// Token: 0x0401A131 RID: 106801
			[Token(Token = "0x401A131")]
			START
		}

		// Token: 0x02003531 RID: 13617
		[Token(Token = "0x2003531")]
		private enum SPActionType
		{
			// Token: 0x0401A133 RID: 106803
			[Token(Token = "0x401A133")]
			INIT,
			// Token: 0x0401A134 RID: 106804
			[Token(Token = "0x401A134")]
			RESUME
		}

		// Token: 0x02003532 RID: 13618
		[Token(Token = "0x2003532")]
		private struct ActionTimer : IHotfixable
		{
			// Token: 0x06015B51 RID: 88913 RVA: 0x0008D918 File Offset: 0x0008BB18
			[Token(Token = "0x6015B51")]
			[Address(RVA = "0xE43750", Offset = "0xE42350", VA = "0x180E43750")]
			public static UICharacterDynIllust.ActionTimer Create(int minSecs, int maxSecs)
			{
				return default(UICharacterDynIllust.ActionTimer);
			}

			// Token: 0x06015B52 RID: 88914 RVA: 0x0008D930 File Offset: 0x0008BB30
			[Token(Token = "0x6015B52")]
			[Address(RVA = "0xE43640", Offset = "0xE42240", VA = "0x180E43640")]
			public bool CheckIfAction(float seconds)
			{
				return default(bool);
			}

			// Token: 0x0401A135 RID: 106805
			[Token(Token = "0x401A135")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private bool m_hasValue;

			// Token: 0x0401A136 RID: 106806
			[Token(Token = "0x401A136")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			private int m_minSecs;

			// Token: 0x0401A137 RID: 106807
			[Token(Token = "0x401A137")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private int m_maxSecs;

			// Token: 0x0401A138 RID: 106808
			[Token(Token = "0x401A138")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private int m_targetSecs;

			// Token: 0x0401A139 RID: 106809
			[Token(Token = "0x401A139")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Create;

			// Token: 0x0401A13A RID: 106810
			[Token(Token = "0x401A13A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_CheckIfAction;
		}
	}
}
