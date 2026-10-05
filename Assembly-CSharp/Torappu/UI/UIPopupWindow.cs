using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI.Loading;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003A15 RID: 14869
	[Token(Token = "0x2003A15")]
	public class UIPopupWindow : SingletonMonoBehaviour<UIPopupWindow>, ISingletonNotAutoCreate, ILuaCallCSharp, IHotfixable
	{
		// Token: 0x06017778 RID: 96120 RVA: 0x00096BA0 File Offset: 0x00094DA0
		[Token(Token = "0x6017778")]
		[Address(RVA = "0xFCE1C0", Offset = "0xFCCDC0", VA = "0x180FCE1C0")]
		public static bool IsBlackLoadingVisible()
		{
			return default(bool);
		}

		// Token: 0x06017779 RID: 96121 RVA: 0x00096BB8 File Offset: 0x00094DB8
		[Token(Token = "0x6017779")]
		[Address(RVA = "0xFCE280", Offset = "0xFCCE80", VA = "0x180FCE280")]
		public bool IsBlackMaskShown()
		{
			return default(bool);
		}

		// Token: 0x0601777A RID: 96122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601777A")]
		[Address(RVA = "0xFCF5E0", Offset = "0xFCE1E0", VA = "0x180FCF5E0")]
		public static IEnumerator ShowBlackLoadingMask()
		{
			return null;
		}

		// Token: 0x0601777B RID: 96123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601777B")]
		[Address(RVA = "0xFCE970", Offset = "0xFCD570", VA = "0x180FCE970")]
		public static UIPopupWindow.ReentrantFloatRef RequestBlackLoadingOpt()
		{
			return null;
		}

		// Token: 0x0601777C RID: 96124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601777C")]
		[Address(RVA = "0xFCDB30", Offset = "0xFCC730", VA = "0x180FCDB30")]
		public static void HideBlackLoadingMask()
		{
		}

		// Token: 0x0601777D RID: 96125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601777D")]
		[Address(RVA = "0xFCDAB0", Offset = "0xFCC6B0", VA = "0x180FCDAB0")]
		public static IEnumerator GetHideBlackLoadingMaskEnumerator()
		{
			return null;
		}

		// Token: 0x0601777E RID: 96126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601777E")]
		[Address(RVA = "0xFD1610", Offset = "0xFD0210", VA = "0x180FD1610")]
		private IEnumerator _ShowBlackLoadingMask()
		{
			return null;
		}

		// Token: 0x0601777F RID: 96127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601777F")]
		[Address(RVA = "0xFD0830", Offset = "0xFCF430", VA = "0x180FD0830")]
		private IEnumerator _HideBlackLoadingMask()
		{
			return null;
		}

		// Token: 0x17003835 RID: 14389
		// (get) Token: 0x06017780 RID: 96128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003835")]
		public static UITransloadingMask transLoadingMask
		{
			[Token(Token = "0x6017780")]
			[Address(RVA = "0xFD2390", Offset = "0xFD0F90", VA = "0x180FD2390")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003836 RID: 14390
		// (get) Token: 0x06017781 RID: 96129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003836")]
		public static UIInvisLoadingMask invisLoadingMask
		{
			[Token(Token = "0x6017781")]
			[Address(RVA = "0xFD2320", Offset = "0xFD0F20", VA = "0x180FD2320")]
			get
			{
				return null;
			}
		}

		// Token: 0x06017782 RID: 96130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017782")]
		[Address(RVA = "0xFCF660", Offset = "0xFCE260", VA = "0x180FCF660")]
		public static void ShowFloatLoadingMask(UIFloatMask floatMask, [Optional] Action callback)
		{
		}

		// Token: 0x06017783 RID: 96131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017783")]
		[Address(RVA = "0xFCDCB0", Offset = "0xFCC8B0", VA = "0x180FCDCB0")]
		public static void HideFloatLoadingMask(UIFloatMask floatMask, [Optional] Action callback)
		{
		}

		// Token: 0x06017784 RID: 96132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017784")]
		[Address(RVA = "0xFCF8A0", Offset = "0xFCE4A0", VA = "0x180FCF8A0")]
		public static void ShowTransLoadingMask()
		{
		}

		// Token: 0x06017785 RID: 96133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017785")]
		[Address(RVA = "0xFCE010", Offset = "0xFCCC10", VA = "0x180FCE010")]
		public static void HideTransLoadingMask([Optional] Action callback)
		{
		}

		// Token: 0x06017786 RID: 96134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017786")]
		[Address(RVA = "0xFD0A40", Offset = "0xFCF640", VA = "0x180FD0A40")]
		private static CommonDialog _InstantiateCommonDialog(CommonDialog prefab, SafeParentComponent parent)
		{
			return null;
		}

		// Token: 0x06017787 RID: 96135 RVA: 0x00096BD0 File Offset: 0x00094DD0
		[Token(Token = "0x6017787")]
		[Address(RVA = "0xFCE2F0", Offset = "0xFCCEF0", VA = "0x180FCE2F0")]
		public bool IsCommonDialogsShowing()
		{
			return default(bool);
		}

		// Token: 0x06017788 RID: 96136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017788")]
		public static DialogType ShowDialog<DialogType>() where DialogType : CommonDialog
		{
			return null;
		}

		// Token: 0x06017789 RID: 96137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017789")]
		public static DialogType ComplexShowDialog<DialogType>(CommonDialog.ShowOptions showOptions) where DialogType : CommonDialog
		{
			return null;
		}

		// Token: 0x0601778A RID: 96138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601778A")]
		[Address(RVA = "0xFD16C0", Offset = "0xFD02C0", VA = "0x180FD16C0")]
		private CommonDialog _ShowDialog(Type dialogType, CommonDialog.ShowOptions options)
		{
			return null;
		}

		// Token: 0x0601778B RID: 96139 RVA: 0x00096BE8 File Offset: 0x00094DE8
		[Token(Token = "0x601778B")]
		[Address(RVA = "0xFD02A0", Offset = "0xFCEEA0", VA = "0x180FD02A0")]
		private bool _DeduplicateDialogInstance(CommonDialog.ShowOptions showRequest)
		{
			return default(bool);
		}

		// Token: 0x0601778C RID: 96140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601778C")]
		[Address(RVA = "0xFCDBD0", Offset = "0xFCC7D0", VA = "0x180FCDBD0")]
		public void HideDialog(CommonDialog dialog, Action callback)
		{
		}

		// Token: 0x0601778D RID: 96141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601778D")]
		[Address(RVA = "0xFD1DD0", Offset = "0xFD09D0", VA = "0x180FD1DD0")]
		private void _UpdatePanelDialogStatus(Action callback)
		{
		}

		// Token: 0x0601778E RID: 96142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601778E")]
		[Address(RVA = "0xFD12C0", Offset = "0xFCFEC0", VA = "0x180FD12C0")]
		private void _SetDialogStatusAsMarked()
		{
		}

		// Token: 0x0601778F RID: 96143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601778F")]
		[Address(RVA = "0xFCD110", Offset = "0xFCBD10", VA = "0x180FCD110")]
		public static void Alert(string content, [Optional] Action onConfirm)
		{
		}

		// Token: 0x06017790 RID: 96144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017790")]
		[Address(RVA = "0xFCFC90", Offset = "0xFCE890", VA = "0x180FCFC90")]
		private void _Alert(string content, [Optional] Action onConfirm)
		{
		}

		// Token: 0x06017791 RID: 96145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017791")]
		[Address(RVA = "0xFCD470", Offset = "0xFCC070", VA = "0x180FCD470")]
		public static void Alerts(List<string> alertList, [Optional] Action onFinish)
		{
		}

		// Token: 0x06017792 RID: 96146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017792")]
		[Address(RVA = "0xFCFE50", Offset = "0xFCEA50", VA = "0x180FCFE50")]
		private void _Alerts(List<string> alertList, Action onFinish)
		{
		}

		// Token: 0x06017793 RID: 96147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017793")]
		[Address(RVA = "0xFCD1B0", Offset = "0xFCBDB0", VA = "0x180FCD1B0")]
		public static void AlertsByResponse(IAlertResponse response, [Optional] Action onFinish)
		{
		}

		// Token: 0x06017794 RID: 96148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017794")]
		[Address(RVA = "0xFCF9D0", Offset = "0xFCE5D0", VA = "0x180FCF9D0")]
		public static void Toast(string content)
		{
		}

		// Token: 0x06017795 RID: 96149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017795")]
		[Address(RVA = "0xFD1C90", Offset = "0xFD0890", VA = "0x180FD1C90")]
		private void _TestBound3DLayoutForce()
		{
		}

		// Token: 0x06017796 RID: 96150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017796")]
		[Address(RVA = "0xFD1CF0", Offset = "0xFD08F0", VA = "0x180FD1CF0")]
		private void _TestBound3DLayout()
		{
		}

		// Token: 0x06017797 RID: 96151 RVA: 0x00096C00 File Offset: 0x00094E00
		[Token(Token = "0x6017797")]
		[Address(RVA = "0xFCE490", Offset = "0xFCD090", VA = "0x180FCE490")]
		public static bool IsGuidebookOpen()
		{
			return default(bool);
		}

		// Token: 0x06017798 RID: 96152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017798")]
		[Address(RVA = "0xFCE8C0", Offset = "0xFCD4C0", VA = "0x180FCE8C0")]
		public static void OpenGuidebook(IList<string> pageIds, [Optional] Action onFinish)
		{
		}

		// Token: 0x06017799 RID: 96153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017799")]
		[Address(RVA = "0xFCE780", Offset = "0xFCD380", VA = "0x180FCE780")]
		public static void OpenGuidebook(string pageId, [Optional] Action onFinish)
		{
		}

		// Token: 0x0601779A RID: 96154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601779A")]
		[Address(RVA = "0xFCE6B0", Offset = "0xFCD2B0", VA = "0x180FCE6B0")]
		public static void OpenGuidebookExt(string[] pageids, int forceRead, Action onFinish)
		{
		}

		// Token: 0x0601779B RID: 96155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601779B")]
		[Address(RVA = "0xFD0E80", Offset = "0xFCFA80", VA = "0x180FD0E80")]
		private void _OpenGuidebook(IList<string> pageIds, int forceRead, Action onFinish)
		{
		}

		// Token: 0x0601779C RID: 96156 RVA: 0x00096C18 File Offset: 0x00094E18
		[Token(Token = "0x601779C")]
		[Address(RVA = "0xFCD510", Offset = "0xFCC110", VA = "0x180FCD510")]
		public static UIPopupWindow.UIBlocker BlockRaycast()
		{
			return default(UIPopupWindow.UIBlocker);
		}

		// Token: 0x0601779D RID: 96157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601779D")]
		[Address(RVA = "0xFCFBE0", Offset = "0xFCE7E0", VA = "0x180FCFBE0")]
		public static IEnumerator WrapWithBlockRaycast(IEnumerator routine)
		{
			return null;
		}

		// Token: 0x0601779E RID: 96158 RVA: 0x00096C30 File Offset: 0x00094E30
		[Token(Token = "0x601779E")]
		[Address(RVA = "0xFD1160", Offset = "0xFCFD60", VA = "0x180FD1160")]
		private UIPopupWindow.UIBlocker _RequestRaycastBlocker()
		{
			return default(UIPopupWindow.UIBlocker);
		}

		// Token: 0x0601779F RID: 96159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601779F")]
		[Address(RVA = "0xFD0FF0", Offset = "0xFCFBF0", VA = "0x180FD0FF0")]
		private void _ReleaseRaycastBlocker(long id)
		{
		}

		// Token: 0x060177A0 RID: 96160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60177A0")]
		[Address(RVA = "0xFD0120", Offset = "0xFCED20", VA = "0x180FD0120")]
		private void _BlockRaycast()
		{
		}

		// Token: 0x060177A1 RID: 96161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60177A1")]
		[Address(RVA = "0xFD1D50", Offset = "0xFD0950", VA = "0x180FD1D50")]
		private void _UnblockRaycast()
		{
		}

		// Token: 0x060177A2 RID: 96162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60177A2")]
		[Address(RVA = "0xFCF740", Offset = "0xFCE340", VA = "0x180FCF740")]
		public static void ShowReentrantLoading()
		{
		}

		// Token: 0x060177A3 RID: 96163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60177A3")]
		[Address(RVA = "0xFCDE20", Offset = "0xFCCA20", VA = "0x180FCDE20")]
		public static void HideReentrantLoading()
		{
		}

		// Token: 0x060177A4 RID: 96164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60177A4")]
		[Address(RVA = "0xFD08E0", Offset = "0xFCF4E0", VA = "0x180FD08E0")]
		private IEnumerator _HideReentrantLoadingCoroutine()
		{
			return null;
		}

		// Token: 0x060177A5 RID: 96165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60177A5")]
		[Address(RVA = "0xFD0580", Offset = "0xFCF180", VA = "0x180FD0580")]
		private ReentrantFloatOpt _EnsureSceneLoading()
		{
			return null;
		}

		// Token: 0x060177A6 RID: 96166 RVA: 0x00096C48 File Offset: 0x00094E48
		[Token(Token = "0x60177A6")]
		[Address(RVA = "0xFD0C10", Offset = "0xFCF810", VA = "0x180FD0C10")]
		private bool _IsSceneLoadingVisible()
		{
			return default(bool);
		}

		// Token: 0x060177A7 RID: 96167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60177A7")]
		[Address(RVA = "0xFD1B40", Offset = "0xFD0740", VA = "0x180FD1B40")]
		private IEnumerator _ShowSceneLoading()
		{
			return null;
		}

		// Token: 0x060177A8 RID: 96168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60177A8")]
		[Address(RVA = "0xFD0990", Offset = "0xFCF590", VA = "0x180FD0990")]
		private IEnumerator _HideSceneLoading()
		{
			return null;
		}

		// Token: 0x060177A9 RID: 96169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60177A9")]
		[Address(RVA = "0xFCF810", Offset = "0xFCE410", VA = "0x180FCF810")]
		public static IEnumerator ShowSceneLoading(string loadingIllust)
		{
			return null;
		}

		// Token: 0x060177AA RID: 96170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60177AA")]
		[Address(RVA = "0xFCDF80", Offset = "0xFCCB80", VA = "0x180FCDF80")]
		public static IEnumerator HideSceneLoading()
		{
			return null;
		}

		// Token: 0x060177AB RID: 96171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60177AB")]
		[Address(RVA = "0xFCEA80", Offset = "0xFCD680", VA = "0x180FCEA80")]
		public static UIPopupWindow.ReentrantFloatRef RequestSceneLoadingOpt()
		{
			return null;
		}

		// Token: 0x060177AC RID: 96172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60177AC")]
		[Address(RVA = "0xFD1BF0", Offset = "0xFD07F0", VA = "0x180FD1BF0")]
		private static void _StartHideSceneLoadingCoroutine()
		{
		}

		// Token: 0x060177AD RID: 96173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60177AD")]
		[Address(RVA = "0xFCEBB0", Offset = "0xFCD7B0", VA = "0x180FCEBB0")]
		public static UIPopupWindow.ReentrantFloatRef RequestSceneOrBlackLoading()
		{
			return null;
		}

		// Token: 0x060177AE RID: 96174 RVA: 0x00096C60 File Offset: 0x00094E60
		[Token(Token = "0x60177AE")]
		[Address(RVA = "0xFCE350", Offset = "0xFCCF50", VA = "0x180FCE350")]
		public bool IsFullScreenMaskVisible()
		{
			return default(bool);
		}

		// Token: 0x060177AF RID: 96175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60177AF")]
		[Address(RVA = "0xFD06F0", Offset = "0xFCF2F0", VA = "0x180FD06F0")]
		private CommonDialog _FindCommonDialogPrefab(Type dialogType)
		{
			return null;
		}

		// Token: 0x060177B0 RID: 96176 RVA: 0x00096C78 File Offset: 0x00094E78
		[Token(Token = "0x60177B0")]
		[Address(RVA = "0xFD0CB0", Offset = "0xFCF8B0", VA = "0x180FD0CB0")]
		private bool _IsWindowActive()
		{
			return default(bool);
		}

		// Token: 0x060177B1 RID: 96177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60177B1")]
		[Address(RVA = "0xFD13E0", Offset = "0xFCFFE0", VA = "0x180FD13E0")]
		private void _SetWindowActive()
		{
		}

		// Token: 0x060177B2 RID: 96178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60177B2")]
		[Address(RVA = "0xFD1470", Offset = "0xFD0070", VA = "0x180FD1470")]
		private void _SetWindowInactive()
		{
		}

		// Token: 0x060177B3 RID: 96179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60177B3")]
		[Address(RVA = "0xFD0D10", Offset = "0xFCF910", VA = "0x180FD0D10")]
		private IEnumerator _NextFrameCoroutine(Action action)
		{
			return null;
		}

		// Token: 0x060177B4 RID: 96180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60177B4")]
		[Address(RVA = "0xFCF210", Offset = "0xFCDE10", VA = "0x180FCF210")]
		public static Sprite ShotBlurredImage(Image outputImage)
		{
			return null;
		}

		// Token: 0x060177B5 RID: 96181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60177B5")]
		[Address(RVA = "0xFCEE40", Offset = "0xFCDA40", VA = "0x180FCEE40")]
		public static Sprite ShotBlurredImageWithOption(Image outputImage, UIPopupWindow.ShotOption shotOption)
		{
			return null;
		}

		// Token: 0x060177B6 RID: 96182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60177B6")]
		[Address(RVA = "0xFCD760", Offset = "0xFCC360", VA = "0x180FCD760")]
		public static List<Camera> FindViewableCameras(UIPopupWindow.ShotOption shotOption)
		{
			return null;
		}

		// Token: 0x060177B7 RID: 96183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60177B7")]
		[Address(RVA = "0xFD01A0", Offset = "0xFCEDA0", VA = "0x180FD01A0")]
		private void _ClearBlurMask()
		{
		}

		// Token: 0x060177B8 RID: 96184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60177B8")]
		[Address(RVA = "0xFD1520", Offset = "0xFD0120", VA = "0x180FD1520")]
		private Sprite _ShotBlurredCamera(UIPopupWindow.ShotOption shotOption)
		{
			return null;
		}

		// Token: 0x060177B9 RID: 96185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60177B9")]
		[Address(RVA = "0xFD0DD0", Offset = "0xFCF9D0", VA = "0x180FD0DD0")]
		private void _OnSceneUnloaded(Scene scene)
		{
		}

		// Token: 0x060177BA RID: 96186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60177BA")]
		[Address(RVA = "0xFCE5E0", Offset = "0xFCD1E0", VA = "0x180FCE5E0", Slot = "4")]
		protected override void OnInit()
		{
		}

		// Token: 0x060177BB RID: 96187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60177BB")]
		[Address(RVA = "0xFCE510", Offset = "0xFCD110", VA = "0x180FCE510", Slot = "7")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x060177BC RID: 96188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60177BC")]
		[Address(RVA = "0xFD2200", Offset = "0xFD0E00", VA = "0x180FD2200")]
		public UIPopupWindow()
		{
		}

		// Token: 0x0401C58A RID: 116106
		[Token(Token = "0x401C58A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Camera _uiCamera;

		// Token: 0x0401C58B RID: 116107
		[Token(Token = "0x401C58B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIReentrantFloatPanel _blackMask;

		// Token: 0x0401C58C RID: 116108
		[Token(Token = "0x401C58C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Tooltip("Material used to blur the background")]
		private Shader _blurShader;

		// Token: 0x0401C58D RID: 116109
		[Token(Token = "0x401C58D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _blurMask;

		// Token: 0x0401C58E RID: 116110
		[Token(Token = "0x401C58E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIGuidebookPanel _guidebookPanel;

		// Token: 0x0401C58F RID: 116111
		[Token(Token = "0x401C58F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private CanvasGroup _panelDialog;

		// Token: 0x0401C590 RID: 116112
		[Token(Token = "0x401C590")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UITransloadingMask _transloadingMask;

		// Token: 0x0401C591 RID: 116113
		[Token(Token = "0x401C591")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIInvisLoadingMask _invisLoadingMask;

		// Token: 0x0401C592 RID: 116114
		[Token(Token = "0x401C592")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CommonDialog[] _dialogPrefabs;

		// Token: 0x0401C593 RID: 116115
		[Token(Token = "0x401C593")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private SafeParentComponent _dialogContainer;

		// Token: 0x0401C594 RID: 116116
		[Token(Token = "0x401C594")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UIToast _toast;

		// Token: 0x0401C595 RID: 116117
		[Token(Token = "0x401C595")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIReentrantFloatPanel _raycastBlocker;

		// Token: 0x0401C596 RID: 116118
		[Token(Token = "0x401C596")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIReentrantFloatPanel _reentrantLoadingMask;

		// Token: 0x0401C597 RID: 116119
		[Token(Token = "0x401C597")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private CommonLoadingController _sceneLoadingMask;

		// Token: 0x0401C598 RID: 116120
		[Token(Token = "0x401C598")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Tween m_dialogTween;

		// Token: 0x0401C599 RID: 116121
		[Token(Token = "0x401C599")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool m_isDialogPanelShown;

		// Token: 0x0401C59A RID: 116122
		[Token(Token = "0x401C59A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		[Inspect]
		[ReadOnly]
		private int m_showCameraCtr;

		// Token: 0x0401C59B RID: 116123
		[Token(Token = "0x401C59B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private List<CommonDialog> m_dialogInsts;

		// Token: 0x0401C59C RID: 116124
		[Token(Token = "0x401C59C")]
		private const long UIBLOCKER_INVALID_ID = 0L;

		// Token: 0x0401C59D RID: 116125
		[Token(Token = "0x401C59D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private ListSet<long> m_activeBlockers;

		// Token: 0x0401C59E RID: 116126
		[Token(Token = "0x401C59E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private long m_activeBlockerIndex;

		// Token: 0x0401C59F RID: 116127
		[Token(Token = "0x401C59F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private UIPopupWindow.SceneLoadingState m_sceneLoadingState;

		// Token: 0x0401C5A0 RID: 116128
		[Token(Token = "0x401C5A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private ReentrantFloatOpt m_sceneLoading;

		// Token: 0x0401C5A1 RID: 116129
		[Token(Token = "0x401C5A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private string m_sceneLoadingIllust;

		// Token: 0x0401C5A2 RID: 116130
		[Token(Token = "0x401C5A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_IsBlackLoadingVisible;

		// Token: 0x0401C5A3 RID: 116131
		[Token(Token = "0x401C5A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_IsBlackMaskShown;

		// Token: 0x0401C5A4 RID: 116132
		[Token(Token = "0x401C5A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ShowBlackLoadingMask;

		// Token: 0x0401C5A5 RID: 116133
		[Token(Token = "0x401C5A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RequestBlackLoadingOpt;

		// Token: 0x0401C5A6 RID: 116134
		[Token(Token = "0x401C5A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_HideBlackLoadingMask;

		// Token: 0x0401C5A7 RID: 116135
		[Token(Token = "0x401C5A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetHideBlackLoadingMaskEnumerator;

		// Token: 0x0401C5A8 RID: 116136
		[Token(Token = "0x401C5A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ShowBlackLoadingMask;

		// Token: 0x0401C5A9 RID: 116137
		[Token(Token = "0x401C5A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__HideBlackLoadingMask;

		// Token: 0x0401C5AA RID: 116138
		[Token(Token = "0x401C5AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_transLoadingMask;

		// Token: 0x0401C5AB RID: 116139
		[Token(Token = "0x401C5AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_invisLoadingMask;

		// Token: 0x0401C5AC RID: 116140
		[Token(Token = "0x401C5AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_ShowFloatLoadingMask;

		// Token: 0x0401C5AD RID: 116141
		[Token(Token = "0x401C5AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_HideFloatLoadingMask;

		// Token: 0x0401C5AE RID: 116142
		[Token(Token = "0x401C5AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_ShowTransLoadingMask;

		// Token: 0x0401C5AF RID: 116143
		[Token(Token = "0x401C5AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_HideTransLoadingMask;

		// Token: 0x0401C5B0 RID: 116144
		[Token(Token = "0x401C5B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__InstantiateCommonDialog;

		// Token: 0x0401C5B1 RID: 116145
		[Token(Token = "0x401C5B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_IsCommonDialogsShowing;

		// Token: 0x0401C5B2 RID: 116146
		[Token(Token = "0x401C5B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_ShowDialog;

		// Token: 0x0401C5B3 RID: 116147
		[Token(Token = "0x401C5B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_ComplexShowDialog;

		// Token: 0x0401C5B4 RID: 116148
		[Token(Token = "0x401C5B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__ShowDialog;

		// Token: 0x0401C5B5 RID: 116149
		[Token(Token = "0x401C5B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__DeduplicateDialogInstance;

		// Token: 0x0401C5B6 RID: 116150
		[Token(Token = "0x401C5B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_HideDialog;

		// Token: 0x0401C5B7 RID: 116151
		[Token(Token = "0x401C5B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__UpdatePanelDialogStatus;

		// Token: 0x0401C5B8 RID: 116152
		[Token(Token = "0x401C5B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__SetDialogStatusAsMarked;

		// Token: 0x0401C5B9 RID: 116153
		[Token(Token = "0x401C5B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_Alert;

		// Token: 0x0401C5BA RID: 116154
		[Token(Token = "0x401C5BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__Alert;

		// Token: 0x0401C5BB RID: 116155
		[Token(Token = "0x401C5BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_Alerts;

		// Token: 0x0401C5BC RID: 116156
		[Token(Token = "0x401C5BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__Alerts;

		// Token: 0x0401C5BD RID: 116157
		[Token(Token = "0x401C5BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_AlertsByResponse;

		// Token: 0x0401C5BE RID: 116158
		[Token(Token = "0x401C5BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_Toast;

		// Token: 0x0401C5BF RID: 116159
		[Token(Token = "0x401C5BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__TestBound3DLayoutForce;

		// Token: 0x0401C5C0 RID: 116160
		[Token(Token = "0x401C5C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__TestBound3DLayout;

		// Token: 0x0401C5C1 RID: 116161
		[Token(Token = "0x401C5C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_IsGuidebookOpen;

		// Token: 0x0401C5C2 RID: 116162
		[Token(Token = "0x401C5C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_OpenGuidebook;

		// Token: 0x0401C5C3 RID: 116163
		[Token(Token = "0x401C5C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix1_OpenGuidebook;

		// Token: 0x0401C5C4 RID: 116164
		[Token(Token = "0x401C5C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_OpenGuidebookExt;

		// Token: 0x0401C5C5 RID: 116165
		[Token(Token = "0x401C5C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0__OpenGuidebook;

		// Token: 0x0401C5C6 RID: 116166
		[Token(Token = "0x401C5C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_BlockRaycast;

		// Token: 0x0401C5C7 RID: 116167
		[Token(Token = "0x401C5C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_WrapWithBlockRaycast;

		// Token: 0x0401C5C8 RID: 116168
		[Token(Token = "0x401C5C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0__RequestRaycastBlocker;

		// Token: 0x0401C5C9 RID: 116169
		[Token(Token = "0x401C5C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0__ReleaseRaycastBlocker;

		// Token: 0x0401C5CA RID: 116170
		[Token(Token = "0x401C5CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0__BlockRaycast;

		// Token: 0x0401C5CB RID: 116171
		[Token(Token = "0x401C5CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0__UnblockRaycast;

		// Token: 0x0401C5CC RID: 116172
		[Token(Token = "0x401C5CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0_ShowReentrantLoading;

		// Token: 0x0401C5CD RID: 116173
		[Token(Token = "0x401C5CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0_HideReentrantLoading;

		// Token: 0x0401C5CE RID: 116174
		[Token(Token = "0x401C5CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0__HideReentrantLoadingCoroutine;

		// Token: 0x0401C5CF RID: 116175
		[Token(Token = "0x401C5CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0__EnsureSceneLoading;

		// Token: 0x0401C5D0 RID: 116176
		[Token(Token = "0x401C5D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0__IsSceneLoadingVisible;

		// Token: 0x0401C5D1 RID: 116177
		[Token(Token = "0x401C5D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0__ShowSceneLoading;

		// Token: 0x0401C5D2 RID: 116178
		[Token(Token = "0x401C5D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0__HideSceneLoading;

		// Token: 0x0401C5D3 RID: 116179
		[Token(Token = "0x401C5D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0_ShowSceneLoading;

		// Token: 0x0401C5D4 RID: 116180
		[Token(Token = "0x401C5D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix0_HideSceneLoading;

		// Token: 0x0401C5D5 RID: 116181
		[Token(Token = "0x401C5D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private static DelegateBridge __Hotfix0_RequestSceneLoadingOpt;

		// Token: 0x0401C5D6 RID: 116182
		[Token(Token = "0x401C5D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private static DelegateBridge __Hotfix0__StartHideSceneLoadingCoroutine;

		// Token: 0x0401C5D7 RID: 116183
		[Token(Token = "0x401C5D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private static DelegateBridge __Hotfix0_RequestSceneOrBlackLoading;

		// Token: 0x0401C5D8 RID: 116184
		[Token(Token = "0x401C5D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private static DelegateBridge __Hotfix0_IsFullScreenMaskVisible;

		// Token: 0x0401C5D9 RID: 116185
		[Token(Token = "0x401C5D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private static DelegateBridge __Hotfix0__FindCommonDialogPrefab;

		// Token: 0x0401C5DA RID: 116186
		[Token(Token = "0x401C5DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private static DelegateBridge __Hotfix0__IsWindowActive;

		// Token: 0x0401C5DB RID: 116187
		[Token(Token = "0x401C5DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private static DelegateBridge __Hotfix0__SetWindowActive;

		// Token: 0x0401C5DC RID: 116188
		[Token(Token = "0x401C5DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private static DelegateBridge __Hotfix0__SetWindowInactive;

		// Token: 0x0401C5DD RID: 116189
		[Token(Token = "0x401C5DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private static DelegateBridge __Hotfix0__NextFrameCoroutine;

		// Token: 0x0401C5DE RID: 116190
		[Token(Token = "0x401C5DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private static DelegateBridge __Hotfix0_ShotBlurredImage;

		// Token: 0x0401C5DF RID: 116191
		[Token(Token = "0x401C5DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private static DelegateBridge __Hotfix0_ShotBlurredImageWithOption;

		// Token: 0x0401C5E0 RID: 116192
		[Token(Token = "0x401C5E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private static DelegateBridge __Hotfix0_FindViewableCameras;

		// Token: 0x0401C5E1 RID: 116193
		[Token(Token = "0x401C5E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private static DelegateBridge __Hotfix0__ClearBlurMask;

		// Token: 0x0401C5E2 RID: 116194
		[Token(Token = "0x401C5E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private static DelegateBridge __Hotfix0__ShotBlurredCamera;

		// Token: 0x0401C5E3 RID: 116195
		[Token(Token = "0x401C5E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private static DelegateBridge __Hotfix0__OnSceneUnloaded;

		// Token: 0x0401C5E4 RID: 116196
		[Token(Token = "0x401C5E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0401C5E5 RID: 116197
		[Token(Token = "0x401C5E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0401C5E6 RID: 116198
		[Token(Token = "0x401C5E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003A16 RID: 14870
		[Token(Token = "0x2003A16")]
		public struct ShotOption
		{
			// Token: 0x0401C5E7 RID: 116199
			[Token(Token = "0x401C5E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static UIPopupWindow.ShotOption EMPTY;

			// Token: 0x0401C5E8 RID: 116200
			[Token(Token = "0x401C5E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<IList<Camera>> hookFindViewableCamerasAction;
		}

		// Token: 0x02003A17 RID: 14871
		[Token(Token = "0x2003A17")]
		public class ReentrantFloatRef : IHotfixable
		{
			// Token: 0x060177BE RID: 96190 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60177BE")]
			[Address(RVA = "0xFC94F0", Offset = "0xFC80F0", VA = "0x180FC94F0")]
			public static UIPopupWindow.ReentrantFloatRef UIPopupWindow_Create(Func<IEnumerator> showCall, Action hideCall)
			{
				return null;
			}

			// Token: 0x060177BF RID: 96191 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60177BF")]
			[Address(RVA = "0xFC9440", Offset = "0xFC8040", VA = "0x180FC9440")]
			public IEnumerator Show()
			{
				return null;
			}

			// Token: 0x060177C0 RID: 96192 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60177C0")]
			[Address(RVA = "0xFC93A0", Offset = "0xFC7FA0", VA = "0x180FC93A0")]
			public void Release()
			{
			}

			// Token: 0x17003837 RID: 14391
			// (get) Token: 0x060177C1 RID: 96193 RVA: 0x00096C90 File Offset: 0x00094E90
			[Token(Token = "0x17003837")]
			public bool isReleased
			{
				[Token(Token = "0x60177C1")]
				[Address(RVA = "0xFC9650", Offset = "0xFC8250", VA = "0x180FC9650")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x060177C2 RID: 96194 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60177C2")]
			[Address(RVA = "0xFC95F0", Offset = "0xFC81F0", VA = "0x180FC95F0")]
			private ReentrantFloatRef()
			{
			}

			// Token: 0x0401C5E9 RID: 116201
			[Token(Token = "0x401C5E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private bool m_isReleased;

			// Token: 0x0401C5EA RID: 116202
			[Token(Token = "0x401C5EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
			private bool m_isActive;

			// Token: 0x0401C5EB RID: 116203
			[Token(Token = "0x401C5EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Func<IEnumerator> m_showCall;

			// Token: 0x0401C5EC RID: 116204
			[Token(Token = "0x401C5EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Action m_hideCall;

			// Token: 0x0401C5ED RID: 116205
			[Token(Token = "0x401C5ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_UIPopupWindow_Create;

			// Token: 0x0401C5EE RID: 116206
			[Token(Token = "0x401C5EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_Show;

			// Token: 0x0401C5EF RID: 116207
			[Token(Token = "0x401C5EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_Release;

			// Token: 0x0401C5F0 RID: 116208
			[Token(Token = "0x401C5F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_isReleased;

			// Token: 0x0401C5F1 RID: 116209
			[Token(Token = "0x401C5F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02003A19 RID: 14873
		[Token(Token = "0x2003A19")]
		public struct UIBlocker
		{
			// Token: 0x060177C9 RID: 96201 RVA: 0x00096CC0 File Offset: 0x00094EC0
			[Token(Token = "0x60177C9")]
			[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120")]
			public static UIPopupWindow.UIBlocker UIPopupWindow_Create(long id)
			{
				return default(UIPopupWindow.UIBlocker);
			}

			// Token: 0x060177CA RID: 96202 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60177CA")]
			[Address(RVA = "0xFCB980", Offset = "0xFCA580", VA = "0x180FCB980")]
			public void Release()
			{
			}

			// Token: 0x0401C5F5 RID: 116213
			[Token(Token = "0x401C5F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly UIPopupWindow.UIBlocker EMPTY;

			// Token: 0x0401C5F6 RID: 116214
			[Token(Token = "0x401C5F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private long m_id;
		}

		// Token: 0x02003A1A RID: 14874
		[Token(Token = "0x2003A1A")]
		private enum SceneLoadingState
		{
			// Token: 0x0401C5F8 RID: 116216
			[Token(Token = "0x401C5F8")]
			NONE,
			// Token: 0x0401C5F9 RID: 116217
			[Token(Token = "0x401C5F9")]
			SHOW,
			// Token: 0x0401C5FA RID: 116218
			[Token(Token = "0x401C5FA")]
			HIDE
		}
	}
}
