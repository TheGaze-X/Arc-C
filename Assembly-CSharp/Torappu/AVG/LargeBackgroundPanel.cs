using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.AVG
{
	// Token: 0x02001ED1 RID: 7889
	[Token(Token = "0x2001ED1")]
	public class LargeBackgroundPanel : ExecutorComponent, IContainsResRefs
	{
		// Token: 0x0600C3A9 RID: 50089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C3A9")]
		[Address(RVA = "0x3413870", Offset = "0x3412470", VA = "0x183413870", Slot = "8")]
		public override Dictionary<string, ExecutorComponent.Executor> GetExecutors()
		{
			return null;
		}

		// Token: 0x0600C3AA RID: 50090 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C3AA")]
		[Address(RVA = "0x3413750", Offset = "0x3412350", VA = "0x183413750", Slot = "13")]
		public AbstractResRefCollecter DontInvoke_PlzImplInternalResRefCollector()
		{
			return null;
		}

		// Token: 0x0600C3AB RID: 50091 RVA: 0x00047D48 File Offset: 0x00045F48
		[Token(Token = "0x600C3AB")]
		[Address(RVA = "0x3415E20", Offset = "0x3414A20", VA = "0x183415E20")]
		private bool _ExecuteImage(Command command)
		{
			return default(bool);
		}

		// Token: 0x0600C3AC RID: 50092 RVA: 0x00047D60 File Offset: 0x00045F60
		[Token(Token = "0x600C3AC")]
		[Address(RVA = "0x3417000", Offset = "0x3415C00", VA = "0x183417000")]
		private bool _ExecuteVerticalBG(Command command)
		{
			return default(bool);
		}

		// Token: 0x0600C3AD RID: 50093 RVA: 0x00047D78 File Offset: 0x00045F78
		[Token(Token = "0x600C3AD")]
		[Address(RVA = "0x3414190", Offset = "0x3412D90", VA = "0x183414190")]
		private bool _ExecuteGridBG(Command command)
		{
			return default(bool);
		}

		// Token: 0x0600C3AE RID: 50094 RVA: 0x00047D90 File Offset: 0x00045F90
		[Token(Token = "0x600C3AE")]
		[Address(RVA = "0x3418FF0", Offset = "0x3417BF0", VA = "0x183418FF0")]
		private static bool _TryExtractCGParam(Command command, ref string image)
		{
			return default(bool);
		}

		// Token: 0x0600C3AF RID: 50095 RVA: 0x00047DA8 File Offset: 0x00045FA8
		[Token(Token = "0x600C3AF")]
		[Address(RVA = "0x3415740", Offset = "0x3414340", VA = "0x183415740")]
		private bool _ExecuteImageTween(Command command)
		{
			return default(bool);
		}

		// Token: 0x0600C3B0 RID: 50096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3B0")]
		[Address(RVA = "0x3413C20", Offset = "0x3412820", VA = "0x183413C20", Slot = "5")]
		public override void OnStoryBegin(Story story)
		{
		}

		// Token: 0x0600C3B1 RID: 50097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3B1")]
		[Address(RVA = "0x3413800", Offset = "0x3412400", VA = "0x183413800", Slot = "12")]
		protected override void ForceCommandEnd()
		{
		}

		// Token: 0x0600C3B2 RID: 50098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3B2")]
		[Address(RVA = "0x3413AD0", Offset = "0x34126D0", VA = "0x183413AD0", Slot = "7")]
		public override void OnReset()
		{
		}

		// Token: 0x0600C3B3 RID: 50099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3B3")]
		[Address(RVA = "0x3418F40", Offset = "0x3417B40", VA = "0x183418F40")]
		private void _ResetPanel()
		{
		}

		// Token: 0x0600C3B4 RID: 50100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3B4")]
		[Address(RVA = "0x3418C40", Offset = "0x3417840", VA = "0x183418C40")]
		private void _ResetImages()
		{
		}

		// Token: 0x0600C3B5 RID: 50101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3B5")]
		[Address(RVA = "0x34189E0", Offset = "0x34175E0", VA = "0x1834189E0")]
		private void _ResetDisplayHandlers()
		{
		}

		// Token: 0x0600C3B6 RID: 50102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3B6")]
		[Address(RVA = "0x3418AD0", Offset = "0x34176D0", VA = "0x183418AD0")]
		private static void _ResetImage(Image img)
		{
		}

		// Token: 0x0600C3B7 RID: 50103 RVA: 0x00047DC0 File Offset: 0x00045FC0
		[Token(Token = "0x600C3B7")]
		[Address(RVA = "0x34185A0", Offset = "0x34171A0", VA = "0x1834185A0")]
		private bool _LoadImage(Image image, string imageName, float width, float height, int idx, bool useCG)
		{
			return default(bool);
		}

		// Token: 0x0600C3B8 RID: 50104 RVA: 0x00047DD8 File Offset: 0x00045FD8
		[Token(Token = "0x600C3B8")]
		[Address(RVA = "0x3418440", Offset = "0x3417040", VA = "0x183418440")]
		private static Vector2 _InitPositionUpperLeft(List<float> width, List<float> height)
		{
			return default(Vector2);
		}

		// Token: 0x0600C3B9 RID: 50105 RVA: 0x00047DF0 File Offset: 0x00045FF0
		[Token(Token = "0x600C3B9")]
		[Address(RVA = "0x3418190", Offset = "0x3416D90", VA = "0x183418190")]
		private static Vector2 _InitPositionCenter(List<float> width, List<float> height)
		{
			return default(Vector2);
		}

		// Token: 0x0600C3BA RID: 50106 RVA: 0x00047E08 File Offset: 0x00046008
		[Token(Token = "0x600C3BA")]
		[Address(RVA = "0x3418350", Offset = "0x3416F50", VA = "0x183418350")]
		private static Vector2 _InitPositionLowerCenter(List<float> width, List<float> height)
		{
			return default(Vector2);
		}

		// Token: 0x0600C3BB RID: 50107 RVA: 0x00047E20 File Offset: 0x00046020
		[Token(Token = "0x600C3BB")]
		[Address(RVA = "0x3418250", Offset = "0x3416E50", VA = "0x183418250")]
		private static Vector2 _InitPositionDefault(List<float> width, List<float> height)
		{
			return default(Vector2);
		}

		// Token: 0x0600C3BC RID: 50108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C3BC")]
		[Address(RVA = "0x3418910", Offset = "0x3417510", VA = "0x183418910")]
		private string _PostDisplayKey(int idx)
		{
			return null;
		}

		// Token: 0x0600C3BD RID: 50109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3BD")]
		[Address(RVA = "0x3413CC0", Offset = "0x34128C0", VA = "0x183413CC0")]
		private void _BindCamEffectTarget()
		{
		}

		// Token: 0x0600C3BE RID: 50110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3BE")]
		[Address(RVA = "0x3414010", Offset = "0x3412C10", VA = "0x183414010")]
		private void _BindPostDisplay(ref PostDisplayHandler handler, string key, Image image, AVGSceneEffectManager effectMgr)
		{
		}

		// Token: 0x0600C3BF RID: 50111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3BF")]
		[Address(RVA = "0x3419370", Offset = "0x3417F70", VA = "0x183419370")]
		public LargeBackgroundPanel()
		{
		}

		// Token: 0x0600C3C1 RID: 50113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3C1")]
		[Address(RVA = "0x33F0E70", Offset = "0x33EFA70", VA = "0x1833F0E70")]
		private void <>xLuaBaseProxy_OnStoryBegin(Story P0)
		{
		}

		// Token: 0x0600C3C2 RID: 50114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3C2")]
		[Address(RVA = "0x1C5FCF0", Offset = "0x1C5E8F0", VA = "0x181C5FCF0")]
		private void <>xLuaBaseProxy_OnReset()
		{
		}

		// Token: 0x0400C5F6 RID: 50678
		[Token(Token = "0x400C5F6")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<string, Func<List<float>, List<float>, Vector2>> POSITION_INIT_FUNCTION;

		// Token: 0x0400C5F7 RID: 50679
		[Token(Token = "0x400C5F7")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private List<Image> _images;

		// Token: 0x0400C5F8 RID: 50680
		[Token(Token = "0x400C5F8")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private RectTransform _initOffset;

		// Token: 0x0400C5F9 RID: 50681
		[Token(Token = "0x400C5F9")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private RectTransform _offset;

		// Token: 0x0400C5FA RID: 50682
		[Token(Token = "0x400C5FA")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Ease _fadeEase;

		// Token: 0x0400C5FB RID: 50683
		[Token(Token = "0x400C5FB")]
		[FieldOffset(Offset = "0x70")]
		private List<PostDisplayHandler> m_largeBgDisplayHandlers;

		// Token: 0x0400C5FC RID: 50684
		[Token(Token = "0x400C5FC")]
		[FieldOffset(Offset = "0x78")]
		private AVGSceneEffectManager m_effectManager;

		// Token: 0x0400C5FD RID: 50685
		[Token(Token = "0x400C5FD")]
		private const int MAX_IMAGE_COUNT = 4;

		// Token: 0x0400C5FE RID: 50686
		[Token(Token = "0x400C5FE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetExecutors;

		// Token: 0x0400C5FF RID: 50687
		[Token(Token = "0x400C5FF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_DontInvoke_PlzImplInternalResRefCollector;

		// Token: 0x0400C600 RID: 50688
		[Token(Token = "0x400C600")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ExecuteImage;

		// Token: 0x0400C601 RID: 50689
		[Token(Token = "0x400C601")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ExecuteVerticalBG;

		// Token: 0x0400C602 RID: 50690
		[Token(Token = "0x400C602")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ExecuteGridBG;

		// Token: 0x0400C603 RID: 50691
		[Token(Token = "0x400C603")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__TryExtractCGParam;

		// Token: 0x0400C604 RID: 50692
		[Token(Token = "0x400C604")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__ExecuteImageTween;

		// Token: 0x0400C605 RID: 50693
		[Token(Token = "0x400C605")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnStoryBegin;

		// Token: 0x0400C606 RID: 50694
		[Token(Token = "0x400C606")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_ForceCommandEnd;

		// Token: 0x0400C607 RID: 50695
		[Token(Token = "0x400C607")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnReset;

		// Token: 0x0400C608 RID: 50696
		[Token(Token = "0x400C608")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__ResetPanel;

		// Token: 0x0400C609 RID: 50697
		[Token(Token = "0x400C609")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__ResetImages;

		// Token: 0x0400C60A RID: 50698
		[Token(Token = "0x400C60A")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__ResetDisplayHandlers;

		// Token: 0x0400C60B RID: 50699
		[Token(Token = "0x400C60B")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__ResetImage;

		// Token: 0x0400C60C RID: 50700
		[Token(Token = "0x400C60C")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__LoadImage;

		// Token: 0x0400C60D RID: 50701
		[Token(Token = "0x400C60D")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__InitPositionUpperLeft;

		// Token: 0x0400C60E RID: 50702
		[Token(Token = "0x400C60E")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__InitPositionCenter;

		// Token: 0x0400C60F RID: 50703
		[Token(Token = "0x400C60F")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__InitPositionLowerCenter;

		// Token: 0x0400C610 RID: 50704
		[Token(Token = "0x400C610")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__InitPositionDefault;

		// Token: 0x0400C611 RID: 50705
		[Token(Token = "0x400C611")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__PostDisplayKey;

		// Token: 0x0400C612 RID: 50706
		[Token(Token = "0x400C612")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__BindCamEffectTarget;

		// Token: 0x0400C613 RID: 50707
		[Token(Token = "0x400C613")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__BindPostDisplay;

		// Token: 0x0400C614 RID: 50708
		[Token(Token = "0x400C614")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001ED2 RID: 7890
		[Token(Token = "0x2001ED2")]
		private class InternalResRefCollector : AbstractResRefCollecter
		{
			// Token: 0x0600C3C3 RID: 50115 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C3C3")]
			[Address(RVA = "0x3413220", Offset = "0x3411E20", VA = "0x183413220", Slot = "4")]
			public override void GatherResRefs(Command command, HashSet<string> references)
			{
			}

			// Token: 0x0600C3C4 RID: 50116 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C3C4")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			public InternalResRefCollector()
			{
			}
		}
	}
}
