using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Resource;
using Torappu.UI.Page;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020035EC RID: 13804
	[Token(Token = "0x20035EC")]
	[DisallowMultipleComponent]
	public class UIPageController : SingletonMonoBehaviour<UIPageController>, ISingletonNotAutoCreate, ILuaCallCSharp, IHotfixable
	{
		// Token: 0x06015FA7 RID: 90023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015FA7")]
		[Address(RVA = "0xE87470", Offset = "0xE86070", VA = "0x180E87470")]
		private IEnumerator _ExperimentalAddTops(IList<UIPageController.AddTopConfig> pageConfigs)
		{
			return null;
		}

		// Token: 0x06015FA8 RID: 90024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015FA8")]
		[Address(RVA = "0xE88FF0", Offset = "0xE87BF0", VA = "0x180E88FF0")]
		private void _PushAddTopConfigToStack(UIPageController.AddTopConfig config)
		{
		}

		// Token: 0x06015FA9 RID: 90025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015FA9")]
		[Address(RVA = "0xE896E0", Offset = "0xE882E0", VA = "0x180E896E0")]
		private void _SetAddTopConfigActiveAndStart(UIPageController.AddTopConfig config)
		{
		}

		// Token: 0x06015FAA RID: 90026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015FAA")]
		[Address(RVA = "0xE88650", Offset = "0xE87250", VA = "0x180E88650")]
		private void _OrderMidPageLayer(UIPage midPage)
		{
		}

		// Token: 0x06015FAB RID: 90027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015FAB")]
		[Address(RVA = "0xE85930", Offset = "0xE84530", VA = "0x180E85930")]
		private IEnumerator _AddMidPagesCoroutine(UIPageController.StackElmt midPage, UIPageOption options)
		{
			return null;
		}

		// Token: 0x06015FAC RID: 90028 RVA: 0x0008EF20 File Offset: 0x0008D120
		[Token(Token = "0x6015FAC")]
		[Address(RVA = "0xE866F0", Offset = "0xE852F0", VA = "0x180E866F0")]
		private static int _CalcResetStackPreserveToIndex(UIPageStackParam param, List<UIPageController.StackElmt> current)
		{
			return 0;
		}

		// Token: 0x06015FAD RID: 90029 RVA: 0x0008EF38 File Offset: 0x0008D138
		[Token(Token = "0x6015FAD")]
		[Address(RVA = "0xE86B70", Offset = "0xE85770", VA = "0x180E86B70")]
		private static int _CalcStackPreserveIndexInResetMode(UIPageStackParam param, List<UIPageController.StackElmt> current)
		{
			return 0;
		}

		// Token: 0x06015FAE RID: 90030 RVA: 0x0008EF50 File Offset: 0x0008D150
		[Token(Token = "0x6015FAE")]
		[Address(RVA = "0xE86970", Offset = "0xE85570", VA = "0x180E86970")]
		private static int _CalcStackPreserveIndexInAppendMode(UIPageStackParam param, List<UIPageController.StackElmt> current)
		{
			return 0;
		}

		// Token: 0x06015FAF RID: 90031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015FAF")]
		[Address(RVA = "0xE83A70", Offset = "0xE82670", VA = "0x180E83A70")]
		public void AdditiveBindPagesFromOtherScene(UIPageTableHolder holder)
		{
		}

		// Token: 0x06015FB0 RID: 90032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015FB0")]
		[Address(RVA = "0xE838D0", Offset = "0xE824D0", VA = "0x180E838D0")]
		public void AdditiveBindDynamicPages(UIDynamicPageHub hub)
		{
		}

		// Token: 0x06015FB1 RID: 90033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015FB1")]
		[Address(RVA = "0xE85780", Offset = "0xE84380", VA = "0x180E85780")]
		public void SetPluginController(UIPageController.PluginController controller)
		{
		}

		// Token: 0x06015FB2 RID: 90034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015FB2")]
		[Address(RVA = "0xE85800", Offset = "0xE84400", VA = "0x180E85800")]
		public void SetSimpleCameraHandler(ISimpleCameraHandler simpleCameraHandler)
		{
		}

		// Token: 0x06015FB3 RID: 90035 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015FB3")]
		[Address(RVA = "0xE836F0", Offset = "0xE822F0", VA = "0x180E836F0")]
		public static List<Camera> AchieveViewableCameras()
		{
			return null;
		}

		// Token: 0x06015FB4 RID: 90036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015FB4")]
		[Address(RVA = "0xE835A0", Offset = "0xE821A0", VA = "0x180E835A0")]
		public static void AchieveViewableCameras(List<Camera> cameras)
		{
		}

		// Token: 0x170034D1 RID: 13521
		// (get) Token: 0x06015FB5 RID: 90037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170034D1")]
		public static Camera simpleCamera
		{
			[Token(Token = "0x6015FB5")]
			[Address(RVA = "0xE8A850", Offset = "0xE89450", VA = "0x180E8A850")]
			get
			{
				return null;
			}
		}

		// Token: 0x06015FB6 RID: 90038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015FB6")]
		[Address(RVA = "0xE84DE0", Offset = "0xE839E0", VA = "0x180E84DE0")]
		public static void OpenPage(string pageName, UIPageOpenType openType, UIPageOption options)
		{
		}

		// Token: 0x06015FB7 RID: 90039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015FB7")]
		[Address(RVA = "0xE84ED0", Offset = "0xE83AD0", VA = "0x180E84ED0")]
		public static void OpenPage(string pageName, UIPageOpenType openType)
		{
		}

		// Token: 0x06015FB8 RID: 90040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015FB8")]
		[Address(RVA = "0xE84FD0", Offset = "0xE83BD0", VA = "0x180E84FD0")]
		public static void OpenPage(string pageName, UIPageOption options)
		{
		}

		// Token: 0x06015FB9 RID: 90041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015FB9")]
		[Address(RVA = "0xE84C60", Offset = "0xE83860", VA = "0x180E84C60")]
		public static void OpenPage(string pageName)
		{
		}

		// Token: 0x06015FBA RID: 90042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015FBA")]
		[Address(RVA = "0xE84420", Offset = "0xE83020", VA = "0x180E84420")]
		public static void ClosePage()
		{
		}

		// Token: 0x06015FBB RID: 90043 RVA: 0x0008EF68 File Offset: 0x0008D168
		[Token(Token = "0x6015FBB")]
		[Address(RVA = "0xE84090", Offset = "0xE82C90", VA = "0x180E84090")]
		public static bool CheckIsVirtualPage(string name, bool onlyFindTopStack = true)
		{
			return default(bool);
		}

		// Token: 0x06015FBC RID: 90044 RVA: 0x0008EF80 File Offset: 0x0008D180
		[Token(Token = "0x6015FBC")]
		[Address(RVA = "0xE83DF0", Offset = "0xE829F0", VA = "0x180E83DF0")]
		public static bool CheckIfNeedReset(string name, bool onlyFindTopStack = true)
		{
			return default(bool);
		}

		// Token: 0x06015FBD RID: 90045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015FBD")]
		[Address(RVA = "0xE84250", Offset = "0xE82E50", VA = "0x180E84250")]
		public static void ClearResetFlag(string name)
		{
		}

		// Token: 0x170034D2 RID: 13522
		// (get) Token: 0x06015FBE RID: 90046 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170034D2")]
		public static UIPage activePage
		{
			[Token(Token = "0x6015FBE")]
			[Address(RVA = "0xE8A5B0", Offset = "0xE891B0", VA = "0x180E8A5B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170034D3 RID: 13523
		// (get) Token: 0x06015FBF RID: 90047 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170034D3")]
		public static string activePageName
		{
			[Token(Token = "0x6015FBF")]
			[Address(RVA = "0xE8A430", Offset = "0xE89030", VA = "0x180E8A430")]
			get
			{
				return null;
			}
		}

		// Token: 0x170034D4 RID: 13524
		// (get) Token: 0x06015FC0 RID: 90048 RVA: 0x0008EF98 File Offset: 0x0008D198
		[Token(Token = "0x170034D4")]
		public static bool isTransiting
		{
			[Token(Token = "0x6015FC0")]
			[Address(RVA = "0xE8A730", Offset = "0xE89330", VA = "0x180E8A730")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170034D5 RID: 13525
		// (get) Token: 0x06015FC1 RID: 90049 RVA: 0x0008EFB0 File Offset: 0x0008D1B0
		[Token(Token = "0x170034D5")]
		public UIPageTransContext transContext
		{
			[Token(Token = "0x6015FC1")]
			[Address(RVA = "0xE8A930", Offset = "0xE89530", VA = "0x180E8A930")]
			get
			{
				return default(UIPageTransContext);
			}
		}

		// Token: 0x06015FC2 RID: 90050 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015FC2")]
		public static T SingleComponent<T>(bool mustExistCheck = false) where T : PageSingleComponent
		{
			return null;
		}

		// Token: 0x06015FC3 RID: 90051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015FC3")]
		public static T SingleComponent<T>(string pageName, bool mustExistCheck = false) where T : PageSingleComponent
		{
			return null;
		}

		// Token: 0x06015FC4 RID: 90052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015FC4")]
		public static T LoadAsset<T>(string path) where T : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x06015FC5 RID: 90053 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015FC5")]
		public static T LoadAsset<T>(string pageName, string path) where T : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x06015FC6 RID: 90054 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015FC6")]
		private static T _LoadAsset<T>(string pageName, string path) where T : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x06015FC7 RID: 90055 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015FC7")]
		private static T _LoadAsset<T>(UIPage page, string path) where T : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x06015FC8 RID: 90056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015FC8")]
		[Address(RVA = "0xE84520", Offset = "0xE83120", VA = "0x180E84520")]
		public static void LoadDefaultIfNot()
		{
		}

		// Token: 0x06015FC9 RID: 90057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015FC9")]
		[Address(RVA = "0xE85140", Offset = "0xE83D40", VA = "0x180E85140")]
		public static void ResetPageStack(UIPageStackParam stackParam)
		{
		}

		// Token: 0x06015FCA RID: 90058 RVA: 0x0008EFC8 File Offset: 0x0008D1C8
		[Token(Token = "0x6015FCA")]
		[Address(RVA = "0xE83FB0", Offset = "0xE82BB0", VA = "0x180E83FB0")]
		public static bool CheckIfPageInStack(string pageName)
		{
			return default(bool);
		}

		// Token: 0x06015FCB RID: 90059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015FCB")]
		[Address(RVA = "0xE84600", Offset = "0xE83200", VA = "0x180E84600")]
		public static void NotifyCurrentPageRouted()
		{
		}

		// Token: 0x06015FCC RID: 90060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015FCC")]
		[Address(RVA = "0xE87780", Offset = "0xE86380", VA = "0x180E87780")]
		private void _InitDynamicPagesIfNeeded()
		{
		}

		// Token: 0x06015FCD RID: 90061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015FCD")]
		[Address(RVA = "0xE89CC0", Offset = "0xE888C0", VA = "0x180E89CC0")]
		private void _UnloadDynamicPagesIfNecessary()
		{
		}

		// Token: 0x06015FCE RID: 90062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015FCE")]
		[Address(RVA = "0xE84730", Offset = "0xE83330", VA = "0x180E84730", Slot = "7")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06015FCF RID: 90063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015FCF")]
		[Address(RVA = "0xE84850", Offset = "0xE83450", VA = "0x180E84850", Slot = "4")]
		protected override void OnInit()
		{
		}

		// Token: 0x06015FD0 RID: 90064 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015FD0")]
		[Address(RVA = "0xE85F30", Offset = "0xE84B30", VA = "0x180E85F30")]
		private IEnumerator _AsyncLoadSubPages()
		{
			return null;
		}

		// Token: 0x06015FD1 RID: 90065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015FD1")]
		[Address(RVA = "0xE87960", Offset = "0xE86560", VA = "0x180E87960")]
		private IEnumerator _LoadInitPageCoroutine()
		{
			return null;
		}

		// Token: 0x06015FD2 RID: 90066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015FD2")]
		[Address(RVA = "0xE88280", Offset = "0xE86E80", VA = "0x180E88280")]
		private void _OpenPage(string pageName, UIPageOpenType openType, UIPageOption options)
		{
		}

		// Token: 0x06015FD3 RID: 90067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015FD3")]
		[Address(RVA = "0xE870C0", Offset = "0xE85CC0", VA = "0x180E870C0")]
		private void _ClosePage()
		{
		}

		// Token: 0x06015FD4 RID: 90068 RVA: 0x0008EFE0 File Offset: 0x0008D1E0
		[Token(Token = "0x6015FD4")]
		[Address(RVA = "0xE86DD0", Offset = "0xE859D0", VA = "0x180E86DD0")]
		private bool _CheckCanAddAsVirtualTop(string pageName)
		{
			return default(bool);
		}

		// Token: 0x06015FD5 RID: 90069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015FD5")]
		[Address(RVA = "0xE85CC0", Offset = "0xE848C0", VA = "0x180E85CC0")]
		private IEnumerator _AddVirtualTop(string name, UIPageOption options)
		{
			return null;
		}

		// Token: 0x06015FD6 RID: 90070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015FD6")]
		[Address(RVA = "0xE89800", Offset = "0xE88400", VA = "0x180E89800")]
		private void _SetOldElemResetFlag(string name)
		{
		}

		// Token: 0x06015FD7 RID: 90071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015FD7")]
		[Address(RVA = "0xE85B90", Offset = "0xE84790", VA = "0x180E85B90")]
		private IEnumerator _AddTop(string name, UIPageOption options, bool isVirtualTop = false)
		{
			return null;
		}

		// Token: 0x06015FD8 RID: 90072 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015FD8")]
		[Address(RVA = "0xE893F0", Offset = "0xE87FF0", VA = "0x180E893F0")]
		private IEnumerator _RemoveTop()
		{
			return null;
		}

		// Token: 0x06015FD9 RID: 90073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015FD9")]
		[Address(RVA = "0xE892E0", Offset = "0xE87EE0", VA = "0x180E892E0")]
		private IEnumerator _RemoveTo(int pageOffset, UIPageOption options)
		{
			return null;
		}

		// Token: 0x06015FDA RID: 90074 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015FDA")]
		[Address(RVA = "0xE894A0", Offset = "0xE880A0", VA = "0x180E894A0")]
		private IEnumerator _ResetStack(UIPageStackParam param)
		{
			return null;
		}

		// Token: 0x06015FDB RID: 90075 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015FDB")]
		[Address(RVA = "0xE85AC0", Offset = "0xE846C0", VA = "0x180E85AC0")]
		private IEnumerator _AddTopPagesDuringResetPageStack(IList<UIPageController.AddTopConfig> pageConfigs)
		{
			return null;
		}

		// Token: 0x06015FDC RID: 90076 RVA: 0x0008EFF8 File Offset: 0x0008D1F8
		[Token(Token = "0x6015FDC")]
		[Address(RVA = "0xE89ED0", Offset = "0xE88AD0", VA = "0x180E89ED0")]
		private static bool _UseFastAddPages(IList<UIPageController.AddTopConfig> pageConfigs)
		{
			return default(bool);
		}

		// Token: 0x06015FDD RID: 90077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015FDD")]
		[Address(RVA = "0xE89FE0", Offset = "0xE88BE0", VA = "0x180E89FE0")]
		private IEnumerator _WrapTransCoroutine(IEnumerator transCoroutine)
		{
			return null;
		}

		// Token: 0x06015FDE RID: 90078 RVA: 0x0008F010 File Offset: 0x0008D210
		[Token(Token = "0x6015FDE")]
		[Address(RVA = "0xE88E10", Offset = "0xE87A10", VA = "0x180E88E10")]
		private UIPageController.StackElmt _PopPageStack()
		{
			return default(UIPageController.StackElmt);
		}

		// Token: 0x06015FDF RID: 90079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015FDF")]
		[Address(RVA = "0xE89150", Offset = "0xE87D50", VA = "0x180E89150")]
		private void _PushPageStack(UIPageController.StackElmt elmt)
		{
		}

		// Token: 0x06015FE0 RID: 90080 RVA: 0x0008F028 File Offset: 0x0008D228
		[Token(Token = "0x6015FE0")]
		[Address(RVA = "0xE88CC0", Offset = "0xE878C0", VA = "0x180E88CC0")]
		private UIPageController.StackElmt _PeekPageStack()
		{
			return default(UIPageController.StackElmt);
		}

		// Token: 0x06015FE1 RID: 90081 RVA: 0x0008F040 File Offset: 0x0008D240
		[Token(Token = "0x6015FE1")]
		[Address(RVA = "0xE87540", Offset = "0xE86140", VA = "0x180E87540")]
		private int _FindIndexInStack(string pageName, bool includeVirtualElm = false)
		{
			return 0;
		}

		// Token: 0x06015FE2 RID: 90082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015FE2")]
		[Address(RVA = "0xE87680", Offset = "0xE86280", VA = "0x180E87680")]
		private UIPage _FindPageInstFromTop(string pageName)
		{
			return null;
		}

		// Token: 0x06015FE3 RID: 90083 RVA: 0x0008F058 File Offset: 0x0008D258
		[Token(Token = "0x6015FE3")]
		[Address(RVA = "0xE87DC0", Offset = "0xE869C0", VA = "0x180E87DC0")]
		private bool _LockTransition()
		{
			return default(bool);
		}

		// Token: 0x06015FE4 RID: 90084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015FE4")]
		[Address(RVA = "0xE89E20", Offset = "0xE88A20", VA = "0x180E89E20")]
		private void _UnlockTransition()
		{
		}

		// Token: 0x06015FE5 RID: 90085 RVA: 0x0008F070 File Offset: 0x0008D270
		[Token(Token = "0x6015FE5")]
		[Address(RVA = "0xE87900", Offset = "0xE86500", VA = "0x180E87900")]
		private bool _IsTransLock()
		{
			return default(bool);
		}

		// Token: 0x06015FE6 RID: 90086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015FE6")]
		[Address(RVA = "0xE86FE0", Offset = "0xE85BE0", VA = "0x180E86FE0")]
		private void _CheckIfToEnableSimpleCamera(UIPage newTop)
		{
		}

		// Token: 0x06015FE7 RID: 90087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015FE7")]
		[Address(RVA = "0xE86EF0", Offset = "0xE85AF0", VA = "0x180E86EF0")]
		private void _CheckIfToDisableSimpleCamera(UIPage newTop)
		{
		}

		// Token: 0x06015FE8 RID: 90088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015FE8")]
		[Address(RVA = "0xE89590", Offset = "0xE88190", VA = "0x180E89590")]
		private void _RestoreTopPageProperties(UIPage newTop)
		{
		}

		// Token: 0x06015FE9 RID: 90089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015FE9")]
		[Address(RVA = "0xE87C80", Offset = "0xE86880", VA = "0x180E87C80")]
		private IEnumerator _LoadTopPageInst(string name, UIPageOption options, Action<UIPage> onPageLoaded)
		{
			return null;
		}

		// Token: 0x06015FEA RID: 90090 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015FEA")]
		[Address(RVA = "0xE87A10", Offset = "0xE86610", VA = "0x180E87A10")]
		private static UIPage _LoadPageFromRouter(IUIPageRouter router, string name)
		{
			return null;
		}

		// Token: 0x06015FEB RID: 90091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015FEB")]
		[Address(RVA = "0xE89AC0", Offset = "0xE886C0", VA = "0x180E89AC0")]
		private void _TryRecyclePageInst(string name, UIPage page)
		{
		}

		// Token: 0x06015FEC RID: 90092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015FEC")]
		[Address(RVA = "0xE899E0", Offset = "0xE885E0", VA = "0x180E899E0")]
		private void _SetPageActive(UIPage page, bool active)
		{
		}

		// Token: 0x06015FED RID: 90093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015FED")]
		[Address(RVA = "0xE85FE0", Offset = "0xE84BE0", VA = "0x180E85FE0")]
		private void _BindInitComponentsOnPage(UIPage page)
		{
		}

		// Token: 0x06015FEE RID: 90094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015FEE")]
		[Address(RVA = "0xE888D0", Offset = "0xE874D0", VA = "0x180E888D0")]
		private void _OrderPageLayers(UIPage lower, UIPage upper)
		{
		}

		// Token: 0x06015FEF RID: 90095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015FEF")]
		[Address(RVA = "0xE85DE0", Offset = "0xE849E0", VA = "0x180E85DE0")]
		private void _AdjustSimplePageSortingLayer(UIPage page, string layerName)
		{
		}

		// Token: 0x06015FF0 RID: 90096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015FF0")]
		[Address(RVA = "0xE87EA0", Offset = "0xE86AA0", VA = "0x180E87EA0")]
		private void _MakeSimplePageHighest()
		{
		}

		// Token: 0x06015FF1 RID: 90097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015FF1")]
		[Address(RVA = "0xE87F30", Offset = "0xE86B30", VA = "0x180E87F30")]
		private void _MakeSimplePageLowest()
		{
		}

		// Token: 0x06015FF2 RID: 90098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015FF2")]
		[Address(RVA = "0xE87140", Offset = "0xE85D40", VA = "0x180E87140")]
		private void _CollectCamerasFromPage(UIPage page, List<Camera> cameras)
		{
		}

		// Token: 0x06015FF3 RID: 90099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015FF3")]
		[Address(RVA = "0xE87FC0", Offset = "0xE86BC0", VA = "0x180E87FC0")]
		private void _OnPageChanged(UIPageController.StackElmt fromPage, UIPageController.StackElmt toPage)
		{
		}

		// Token: 0x06015FF4 RID: 90100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015FF4")]
		[Address(RVA = "0xE863B0", Offset = "0xE84FB0", VA = "0x180E863B0")]
		private static string _CalcPagePosTest(string hex)
		{
			return null;
		}

		// Token: 0x06015FF5 RID: 90101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015FF5")]
		[Address(RVA = "0xE85250", Offset = "0xE83E50", VA = "0x180E85250")]
		public static void ResetPageTestStatus(bool isForce, Action<string, string> callback)
		{
		}

		// Token: 0x06015FF6 RID: 90102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015FF6")]
		[Address(RVA = "0xE872F0", Offset = "0xE85EF0", VA = "0x180E872F0")]
		private static string _ConvertName(string fieldName, string code1, string code2)
		{
			return null;
		}

		// Token: 0x06015FF7 RID: 90103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015FF7")]
		[Address(RVA = "0xE8A0B0", Offset = "0xE88CB0", VA = "0x180E8A0B0")]
		public UIPageController()
		{
		}

		// Token: 0x0401A695 RID: 108181
		[Token(Token = "0x401A695")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private List<UIPageController.AddTopConfig> m_midPageConfigs;

		// Token: 0x0401A696 RID: 108182
		[Token(Token = "0x401A696")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<IEnumerator> m_sharedIterList;

		// Token: 0x0401A697 RID: 108183
		[Token(Token = "0x401A697")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Config")]
		private UIPageTable[] _pageTables;

		// Token: 0x0401A698 RID: 108184
		[Token(Token = "0x401A698")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Group("Default Page")]
		[SerializeField]
		[Tooltip("The default page would be added when scene loaded")]
		private string _defaultPageName;

		// Token: 0x0401A699 RID: 108185
		[Token(Token = "0x401A699")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Config")]
		private Transform _pageContainer;

		// Token: 0x0401A69A RID: 108186
		[Token(Token = "0x401A69A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Config")]
		private Camera _simplePageCamera;

		// Token: 0x0401A69B RID: 108187
		[Token(Token = "0x401A69B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Default Page")]
		private bool _loadDefaultWhenStart;

		// Token: 0x0401A69C RID: 108188
		[Token(Token = "0x401A69C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Config")]
		private List<string> _subPageScenes;

		// Token: 0x0401A69D RID: 108189
		[Token(Token = "0x401A69D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool m_isInited;

		// Token: 0x0401A69E RID: 108190
		[Token(Token = "0x401A69E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private IUIPageRouter m_router;

		// Token: 0x0401A69F RID: 108191
		[Token(Token = "0x401A69F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Inspect(Level = 2)]
		private List<UIPageController.StackElmt> m_pageStack;

		// Token: 0x0401A6A0 RID: 108192
		[Token(Token = "0x401A6A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Inspect(Level = 2)]
		private ListDict<string, UIPage> m_pagePool;

		// Token: 0x0401A6A1 RID: 108193
		[Token(Token = "0x401A6A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private bool m_isTransiting;

		// Token: 0x0401A6A2 RID: 108194
		[Token(Token = "0x401A6A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private long m_transLockSignal;

		// Token: 0x0401A6A3 RID: 108195
		[Token(Token = "0x401A6A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private UIPageTransContext m_transContext;

		// Token: 0x0401A6A4 RID: 108196
		[Token(Token = "0x401A6A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private UIPage m_prevPageInst;

		// Token: 0x0401A6A5 RID: 108197
		[Token(Token = "0x401A6A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private UIPageController.PluginController m_pluginController;

		// Token: 0x0401A6A6 RID: 108198
		[Token(Token = "0x401A6A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private List<string> m_additiveScenes;

		// Token: 0x0401A6A7 RID: 108199
		[Token(Token = "0x401A6A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private UIPageController.PageTransBlocker m_transBlocker;

		// Token: 0x0401A6A8 RID: 108200
		[Token(Token = "0x401A6A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private ISimpleCameraHandler m_simpleCameraHandler;

		// Token: 0x0401A6A9 RID: 108201
		[Token(Token = "0x401A6A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private UIPageCameraProvider m_virtualCameraProvider;

		// Token: 0x0401A6AA RID: 108202
		[Token(Token = "0x401A6AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool m_loadAddSceneTrigger;

		// Token: 0x0401A6AB RID: 108203
		[Token(Token = "0x401A6AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private CachedAssetLoader m_selfAssetLoader;

		// Token: 0x0401A6AC RID: 108204
		[Token(Token = "0x401A6AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private UIPopupWindow.UIBlocker m_globalRaycastBlocker;

		// Token: 0x0401A6AD RID: 108205
		[Token(Token = "0x401A6AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private UIPopupWindow.ReentrantFloatRef m_globalBlackMask;

		// Token: 0x0401A6AE RID: 108206
		[Token(Token = "0x401A6AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private DynamicPageLoader m_dynamicPageLoader;

		// Token: 0x0401A6AF RID: 108207
		[Token(Token = "0x401A6AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool s_isPageTestInited;

		// Token: 0x0401A6B0 RID: 108208
		[Token(Token = "0x401A6B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__ExperimentalAddTops;

		// Token: 0x0401A6B1 RID: 108209
		[Token(Token = "0x401A6B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__PushAddTopConfigToStack;

		// Token: 0x0401A6B2 RID: 108210
		[Token(Token = "0x401A6B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__SetAddTopConfigActiveAndStart;

		// Token: 0x0401A6B3 RID: 108211
		[Token(Token = "0x401A6B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OrderMidPageLayer;

		// Token: 0x0401A6B4 RID: 108212
		[Token(Token = "0x401A6B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__AddMidPagesCoroutine;

		// Token: 0x0401A6B5 RID: 108213
		[Token(Token = "0x401A6B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__CalcResetStackPreserveToIndex;

		// Token: 0x0401A6B6 RID: 108214
		[Token(Token = "0x401A6B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__CalcStackPreserveIndexInResetMode;

		// Token: 0x0401A6B7 RID: 108215
		[Token(Token = "0x401A6B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__CalcStackPreserveIndexInAppendMode;

		// Token: 0x0401A6B8 RID: 108216
		[Token(Token = "0x401A6B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_AdditiveBindPagesFromOtherScene;

		// Token: 0x0401A6B9 RID: 108217
		[Token(Token = "0x401A6B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_AdditiveBindDynamicPages;

		// Token: 0x0401A6BA RID: 108218
		[Token(Token = "0x401A6BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_SetPluginController;

		// Token: 0x0401A6BB RID: 108219
		[Token(Token = "0x401A6BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_SetSimpleCameraHandler;

		// Token: 0x0401A6BC RID: 108220
		[Token(Token = "0x401A6BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_AchieveViewableCameras;

		// Token: 0x0401A6BD RID: 108221
		[Token(Token = "0x401A6BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix1_AchieveViewableCameras;

		// Token: 0x0401A6BE RID: 108222
		[Token(Token = "0x401A6BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_get_simpleCamera;

		// Token: 0x0401A6BF RID: 108223
		[Token(Token = "0x401A6BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_OpenPage;

		// Token: 0x0401A6C0 RID: 108224
		[Token(Token = "0x401A6C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix1_OpenPage;

		// Token: 0x0401A6C1 RID: 108225
		[Token(Token = "0x401A6C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix2_OpenPage;

		// Token: 0x0401A6C2 RID: 108226
		[Token(Token = "0x401A6C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix3_OpenPage;

		// Token: 0x0401A6C3 RID: 108227
		[Token(Token = "0x401A6C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_ClosePage;

		// Token: 0x0401A6C4 RID: 108228
		[Token(Token = "0x401A6C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_CheckIsVirtualPage;

		// Token: 0x0401A6C5 RID: 108229
		[Token(Token = "0x401A6C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_CheckIfNeedReset;

		// Token: 0x0401A6C6 RID: 108230
		[Token(Token = "0x401A6C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_ClearResetFlag;

		// Token: 0x0401A6C7 RID: 108231
		[Token(Token = "0x401A6C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_get_activePage;

		// Token: 0x0401A6C8 RID: 108232
		[Token(Token = "0x401A6C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_get_activePageName;

		// Token: 0x0401A6C9 RID: 108233
		[Token(Token = "0x401A6C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_get_isTransiting;

		// Token: 0x0401A6CA RID: 108234
		[Token(Token = "0x401A6CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_get_transContext;

		// Token: 0x0401A6CB RID: 108235
		[Token(Token = "0x401A6CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_SingleComponent;

		// Token: 0x0401A6CC RID: 108236
		[Token(Token = "0x401A6CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix1_SingleComponent;

		// Token: 0x0401A6CD RID: 108237
		[Token(Token = "0x401A6CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_LoadAsset;

		// Token: 0x0401A6CE RID: 108238
		[Token(Token = "0x401A6CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix1_LoadAsset;

		// Token: 0x0401A6CF RID: 108239
		[Token(Token = "0x401A6CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__LoadAsset;

		// Token: 0x0401A6D0 RID: 108240
		[Token(Token = "0x401A6D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix1__LoadAsset;

		// Token: 0x0401A6D1 RID: 108241
		[Token(Token = "0x401A6D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_LoadDefaultIfNot;

		// Token: 0x0401A6D2 RID: 108242
		[Token(Token = "0x401A6D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_ResetPageStack;

		// Token: 0x0401A6D3 RID: 108243
		[Token(Token = "0x401A6D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_CheckIfPageInStack;

		// Token: 0x0401A6D4 RID: 108244
		[Token(Token = "0x401A6D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_NotifyCurrentPageRouted;

		// Token: 0x0401A6D5 RID: 108245
		[Token(Token = "0x401A6D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0__InitDynamicPagesIfNeeded;

		// Token: 0x0401A6D6 RID: 108246
		[Token(Token = "0x401A6D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0__UnloadDynamicPagesIfNecessary;

		// Token: 0x0401A6D7 RID: 108247
		[Token(Token = "0x401A6D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0401A6D8 RID: 108248
		[Token(Token = "0x401A6D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0401A6D9 RID: 108249
		[Token(Token = "0x401A6D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0__AsyncLoadSubPages;

		// Token: 0x0401A6DA RID: 108250
		[Token(Token = "0x401A6DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0__LoadInitPageCoroutine;

		// Token: 0x0401A6DB RID: 108251
		[Token(Token = "0x401A6DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0__OpenPage;

		// Token: 0x0401A6DC RID: 108252
		[Token(Token = "0x401A6DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0__ClosePage;

		// Token: 0x0401A6DD RID: 108253
		[Token(Token = "0x401A6DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0__CheckCanAddAsVirtualTop;

		// Token: 0x0401A6DE RID: 108254
		[Token(Token = "0x401A6DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0__AddVirtualTop;

		// Token: 0x0401A6DF RID: 108255
		[Token(Token = "0x401A6DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0__SetOldElemResetFlag;

		// Token: 0x0401A6E0 RID: 108256
		[Token(Token = "0x401A6E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0__AddTop;

		// Token: 0x0401A6E1 RID: 108257
		[Token(Token = "0x401A6E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix0__RemoveTop;

		// Token: 0x0401A6E2 RID: 108258
		[Token(Token = "0x401A6E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private static DelegateBridge __Hotfix0__RemoveTo;

		// Token: 0x0401A6E3 RID: 108259
		[Token(Token = "0x401A6E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private static DelegateBridge __Hotfix0__ResetStack;

		// Token: 0x0401A6E4 RID: 108260
		[Token(Token = "0x401A6E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private static DelegateBridge __Hotfix0__AddTopPagesDuringResetPageStack;

		// Token: 0x0401A6E5 RID: 108261
		[Token(Token = "0x401A6E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private static DelegateBridge __Hotfix0__UseFastAddPages;

		// Token: 0x0401A6E6 RID: 108262
		[Token(Token = "0x401A6E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private static DelegateBridge __Hotfix0__WrapTransCoroutine;

		// Token: 0x0401A6E7 RID: 108263
		[Token(Token = "0x401A6E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private static DelegateBridge __Hotfix0__PopPageStack;

		// Token: 0x0401A6E8 RID: 108264
		[Token(Token = "0x401A6E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private static DelegateBridge __Hotfix0__PushPageStack;

		// Token: 0x0401A6E9 RID: 108265
		[Token(Token = "0x401A6E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private static DelegateBridge __Hotfix0__PeekPageStack;

		// Token: 0x0401A6EA RID: 108266
		[Token(Token = "0x401A6EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private static DelegateBridge __Hotfix0__FindIndexInStack;

		// Token: 0x0401A6EB RID: 108267
		[Token(Token = "0x401A6EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private static DelegateBridge __Hotfix0__FindPageInstFromTop;

		// Token: 0x0401A6EC RID: 108268
		[Token(Token = "0x401A6EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private static DelegateBridge __Hotfix0__LockTransition;

		// Token: 0x0401A6ED RID: 108269
		[Token(Token = "0x401A6ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private static DelegateBridge __Hotfix0__UnlockTransition;

		// Token: 0x0401A6EE RID: 108270
		[Token(Token = "0x401A6EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private static DelegateBridge __Hotfix0__IsTransLock;

		// Token: 0x0401A6EF RID: 108271
		[Token(Token = "0x401A6EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private static DelegateBridge __Hotfix0__CheckIfToEnableSimpleCamera;

		// Token: 0x0401A6F0 RID: 108272
		[Token(Token = "0x401A6F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private static DelegateBridge __Hotfix0__CheckIfToDisableSimpleCamera;

		// Token: 0x0401A6F1 RID: 108273
		[Token(Token = "0x401A6F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		private static DelegateBridge __Hotfix0__RestoreTopPageProperties;

		// Token: 0x0401A6F2 RID: 108274
		[Token(Token = "0x401A6F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private static DelegateBridge __Hotfix0__LoadTopPageInst;

		// Token: 0x0401A6F3 RID: 108275
		[Token(Token = "0x401A6F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		private static DelegateBridge __Hotfix0__LoadPageFromRouter;

		// Token: 0x0401A6F4 RID: 108276
		[Token(Token = "0x401A6F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		private static DelegateBridge __Hotfix0__TryRecyclePageInst;

		// Token: 0x0401A6F5 RID: 108277
		[Token(Token = "0x401A6F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		private static DelegateBridge __Hotfix0__SetPageActive;

		// Token: 0x0401A6F6 RID: 108278
		[Token(Token = "0x401A6F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		private static DelegateBridge __Hotfix0__BindInitComponentsOnPage;

		// Token: 0x0401A6F7 RID: 108279
		[Token(Token = "0x401A6F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		private static DelegateBridge __Hotfix0__OrderPageLayers;

		// Token: 0x0401A6F8 RID: 108280
		[Token(Token = "0x401A6F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		private static DelegateBridge __Hotfix0__AdjustSimplePageSortingLayer;

		// Token: 0x0401A6F9 RID: 108281
		[Token(Token = "0x401A6F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		private static DelegateBridge __Hotfix0__MakeSimplePageHighest;

		// Token: 0x0401A6FA RID: 108282
		[Token(Token = "0x401A6FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		private static DelegateBridge __Hotfix0__MakeSimplePageLowest;

		// Token: 0x0401A6FB RID: 108283
		[Token(Token = "0x401A6FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
		private static DelegateBridge __Hotfix0__CollectCamerasFromPage;

		// Token: 0x0401A6FC RID: 108284
		[Token(Token = "0x401A6FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
		private static DelegateBridge __Hotfix0__OnPageChanged;

		// Token: 0x0401A6FD RID: 108285
		[Token(Token = "0x401A6FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
		private static DelegateBridge __Hotfix0__CalcPagePosTest;

		// Token: 0x0401A6FE RID: 108286
		[Token(Token = "0x401A6FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
		private static DelegateBridge __Hotfix0_ResetPageTestStatus;

		// Token: 0x0401A6FF RID: 108287
		[Token(Token = "0x401A6FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
		private static DelegateBridge __Hotfix0__ConvertName;

		// Token: 0x0401A700 RID: 108288
		[Token(Token = "0x401A700")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020035ED RID: 13805
		[Token(Token = "0x20035ED")]
		private class AddTopConfig
		{
			// Token: 0x06015FF8 RID: 90104 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015FF8")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public AddTopConfig()
			{
			}

			// Token: 0x0401A701 RID: 108289
			[Token(Token = "0x401A701")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string name;

			// Token: 0x0401A702 RID: 108290
			[Token(Token = "0x401A702")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public UIPageOption options;

			// Token: 0x0401A703 RID: 108291
			[Token(Token = "0x401A703")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public UIPage pageInst;

			// Token: 0x0401A704 RID: 108292
			[Token(Token = "0x401A704")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public UIPageController.StackElmt stackElmt;
		}

		// Token: 0x020035EE RID: 13806
		[Token(Token = "0x20035EE")]
		private struct StackElmt
		{
			// Token: 0x170034D6 RID: 13526
			// (get) Token: 0x06015FF9 RID: 90105 RVA: 0x0008F088 File Offset: 0x0008D288
			[Token(Token = "0x170034D6")]
			public bool isEmpty
			{
				[Token(Token = "0x6015FF9")]
				[Address(RVA = "0xE7D6D0", Offset = "0xE7C2D0", VA = "0x180E7D6D0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0401A705 RID: 108293
			[Token(Token = "0x401A705")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string name;

			// Token: 0x0401A706 RID: 108294
			[Token(Token = "0x401A706")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public UIPage pageInst;

			// Token: 0x0401A707 RID: 108295
			[Token(Token = "0x401A707")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UIPageController.VirtualTopData virtualTopData;
		}

		// Token: 0x020035EF RID: 13807
		[Token(Token = "0x20035EF")]
		public enum VirtualTopResetRule
		{
			// Token: 0x0401A709 RID: 108297
			[Token(Token = "0x401A709")]
			CLEAR_INPUT,
			// Token: 0x0401A70A RID: 108298
			[Token(Token = "0x401A70A")]
			DO_NOTHING
		}

		// Token: 0x020035F0 RID: 13808
		[Token(Token = "0x20035F0")]
		private struct VirtualTopData
		{
			// Token: 0x0401A70B RID: 108299
			[Token(Token = "0x401A70B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool isVirtualTop;

			// Token: 0x0401A70C RID: 108300
			[Token(Token = "0x401A70C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public bool resetFlag;

			// Token: 0x0401A70D RID: 108301
			[Token(Token = "0x401A70D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public UIPageController.VirtualTopResetRule virtualTopResetRule;

			// Token: 0x0401A70E RID: 108302
			[Token(Token = "0x401A70E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public object cachedPageArgs;
		}

		// Token: 0x020035F1 RID: 13809
		[Token(Token = "0x20035F1")]
		public class PluginController
		{
			// Token: 0x06015FFA RID: 90106 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015FFA")]
			[Address(RVA = "0xE7D570", Offset = "0xE7C170", VA = "0x180E7D570")]
			public void PublicAddPlugin(UIPage page)
			{
			}

			// Token: 0x06015FFB RID: 90107 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015FFB")]
			[Address(RVA = "0xE7D620", Offset = "0xE7C220", VA = "0x180E7D620")]
			private void _SetPluginInner(UIPage target, UIPage.Plugin plugin)
			{
			}

			// Token: 0x06015FFC RID: 90108 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015FFC")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "4")]
			protected virtual void AddPlugin(UIPage page, Action<UIPage, UIPage.Plugin> pluginSetter)
			{
			}

			// Token: 0x06015FFD RID: 90109 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015FFD")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PluginController()
			{
			}
		}

		// Token: 0x020035F2 RID: 13810
		[Token(Token = "0x20035F2")]
		public class PageTransBlocker : IHotfixable
		{
			// Token: 0x06015FFE RID: 90110 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015FFE")]
			[Address(RVA = "0xE7D200", Offset = "0xE7BE00", VA = "0x180E7D200")]
			public void BlockPages(UIPage page1, [Optional] UIPage page2)
			{
			}

			// Token: 0x06015FFF RID: 90111 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015FFF")]
			[Address(RVA = "0xE7D380", Offset = "0xE7BF80", VA = "0x180E7D380")]
			public void ReleaseBlocks()
			{
			}

			// Token: 0x06016000 RID: 90112 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016000")]
			[Address(RVA = "0xE7D3E0", Offset = "0xE7BFE0", VA = "0x180E7D3E0")]
			private void _Reset()
			{
			}

			// Token: 0x06016001 RID: 90113 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016001")]
			[Address(RVA = "0xE7D4A0", Offset = "0xE7C0A0", VA = "0x180E7D4A0")]
			public PageTransBlocker()
			{
			}

			// Token: 0x0401A70F RID: 108303
			[Token(Token = "0x401A70F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private RefCountReference m_ref1;

			// Token: 0x0401A710 RID: 108304
			[Token(Token = "0x401A710")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private UIPage.UIBlockHandler m_blocker1;

			// Token: 0x0401A711 RID: 108305
			[Token(Token = "0x401A711")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private RefCountReference m_ref2;

			// Token: 0x0401A712 RID: 108306
			[Token(Token = "0x401A712")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UIPage.UIBlockHandler m_blocker2;

			// Token: 0x0401A713 RID: 108307
			[Token(Token = "0x401A713")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_BlockPages;

			// Token: 0x0401A714 RID: 108308
			[Token(Token = "0x401A714")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_ReleaseBlocks;

			// Token: 0x0401A715 RID: 108309
			[Token(Token = "0x401A715")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0__Reset;

			// Token: 0x0401A716 RID: 108310
			[Token(Token = "0x401A716")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
