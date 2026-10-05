using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Spine.Unity;
using Torappu.UI.Stencil;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200385E RID: 14430
	[Token(Token = "0x200385E")]
	[RequireComponent(typeof(RectTransform))]
	public class UISpineHolder : MonoBehaviour, IHotfixable
	{
		// Token: 0x06016DAC RID: 93612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016DAC")]
		[Address(RVA = "0xF4E960", Offset = "0xF4D560", VA = "0x180F4E960")]
		private SkeletonAnimation _LoadBattleSpine(string skinId, out UnityEngine.Object asset, out float spineScale)
		{
			return null;
		}

		// Token: 0x06016DAD RID: 93613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016DAD")]
		[Address(RVA = "0xF4EDB0", Offset = "0xF4D9B0", VA = "0x180F4EDB0")]
		private SkeletonAnimation _LoadBuildingSpine(string skinId, out UnityEngine.Object asset, out float spineScale)
		{
			return null;
		}

		// Token: 0x06016DAE RID: 93614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016DAE")]
		[Address(RVA = "0xF4F060", Offset = "0xF4DC60", VA = "0x180F4F060")]
		private SkeletonGraphic _LoadDynAvatarSpine(string spineId, out UnityEngine.Object asset, out float spineScale)
		{
			return null;
		}

		// Token: 0x06016DAF RID: 93615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016DAF")]
		[Address(RVA = "0xF4DB80", Offset = "0xF4C780", VA = "0x180F4DB80")]
		public void Init(UISpineHolder.Adapter adapter)
		{
		}

		// Token: 0x06016DB0 RID: 93616 RVA: 0x000934E0 File Offset: 0x000916E0
		[Token(Token = "0x6016DB0")]
		[Address(RVA = "0xF4F460", Offset = "0xF4E060", VA = "0x180F4F460")]
		private bool _RenderByAdapter(UISpineHolder.Adapter adapter)
		{
			return default(bool);
		}

		// Token: 0x06016DB1 RID: 93617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016DB1")]
		[Address(RVA = "0xF4E100", Offset = "0xF4CD00", VA = "0x180F4E100")]
		private void _ApplyTransform(Misc.TRS transformParam, float spineScale)
		{
		}

		// Token: 0x06016DB2 RID: 93618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016DB2")]
		[Address(RVA = "0xF4F230", Offset = "0xF4DE30", VA = "0x180F4F230")]
		private IEnumerator _LoadSpineGraphic(UISpineHolder.LoadSpineParam param)
		{
			return null;
		}

		// Token: 0x06016DB3 RID: 93619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016DB3")]
		[Address(RVA = "0xF4F990", Offset = "0xF4E590", VA = "0x180F4F990")]
		private void _UpdateSpineAnimParam(SkeletonGraphic graphic, UISpineHolder.SpineAnimParam animParam)
		{
		}

		// Token: 0x06016DB4 RID: 93620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016DB4")]
		[Address(RVA = "0xF4F330", Offset = "0xF4DF30", VA = "0x180F4F330")]
		private void _ReleaseIfNot()
		{
		}

		// Token: 0x06016DB5 RID: 93621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016DB5")]
		[Address(RVA = "0xF4E420", Offset = "0xF4D020", VA = "0x180F4E420")]
		private void _EnableReverseMode()
		{
		}

		// Token: 0x06016DB6 RID: 93622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016DB6")]
		[Address(RVA = "0xF4E290", Offset = "0xF4CE90", VA = "0x180F4E290")]
		private void _DisableReverseMode()
		{
		}

		// Token: 0x06016DB7 RID: 93623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016DB7")]
		[Address(RVA = "0xF4F900", Offset = "0xF4E500", VA = "0x180F4F900")]
		private void _ReverseMeshOrder(bool reverseMesh)
		{
		}

		// Token: 0x06016DB8 RID: 93624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016DB8")]
		[Address(RVA = "0xF4DCA0", Offset = "0xF4C8A0", VA = "0x180F4DCA0")]
		private void Update()
		{
		}

		// Token: 0x06016DB9 RID: 93625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016DB9")]
		[Address(RVA = "0xF4DC40", Offset = "0xF4C840", VA = "0x180F4DC40")]
		private void OnDestroy()
		{
		}

		// Token: 0x06016DBA RID: 93626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016DBA")]
		[Address(RVA = "0xF4E840", Offset = "0xF4D440", VA = "0x180F4E840")]
		private Material _InitSpineMaterial(UISpineHolder.SpineMatParam matParam)
		{
			return null;
		}

		// Token: 0x06016DBB RID: 93627 RVA: 0x000934F8 File Offset: 0x000916F8
		[Token(Token = "0x6016DBB")]
		[Address(RVA = "0xF4E5C0", Offset = "0xF4D1C0", VA = "0x180F4E5C0")]
		private UISpineHolder.LoadSpineParam _GenerateLoadSpineParam(UISpineHolder.Adapter adapter)
		{
			return default(UISpineHolder.LoadSpineParam);
		}

		// Token: 0x06016DBC RID: 93628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016DBC")]
		[Address(RVA = "0xF4FC50", Offset = "0xF4E850", VA = "0x180F4FC50")]
		public UISpineHolder()
		{
		}

		// Token: 0x0401B905 RID: 112901
		[Token(Token = "0x401B905")]
		private const int REVERSE_MODE = 1;

		// Token: 0x0401B906 RID: 112902
		[Token(Token = "0x401B906")]
		private const float DEFAULT_FADEOUT_ALPHA = 0.85f;

		// Token: 0x0401B907 RID: 112903
		[Token(Token = "0x401B907")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool _enableReverseMode;

		// Token: 0x0401B908 RID: 112904
		[Token(Token = "0x401B908")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIStencilMaskable _stencilCleaner;

		// Token: 0x0401B909 RID: 112905
		[Token(Token = "0x401B909")]
		[FieldOffset(Offset = "0x28")]
		private Material m_material;

		// Token: 0x0401B90A RID: 112906
		[Token(Token = "0x401B90A")]
		[FieldOffset(Offset = "0x30")]
		private UISpineHolder.SpineAsset m_asset;

		// Token: 0x0401B90B RID: 112907
		[Token(Token = "0x401B90B")]
		[FieldOffset(Offset = "0x60")]
		private UISpineHolder.Adapter m_adapter;

		// Token: 0x0401B90C RID: 112908
		[Token(Token = "0x401B90C")]
		[FieldOffset(Offset = "0x68")]
		private SkeletonGraphic m_graphic;

		// Token: 0x0401B90D RID: 112909
		[Token(Token = "0x401B90D")]
		[FieldOffset(Offset = "0x70")]
		private IEnumerator m_loadCoroutine;

		// Token: 0x0401B90E RID: 112910
		[Token(Token = "0x401B90E")]
		[FieldOffset(Offset = "0x78")]
		private bool m_isFadingOut;

		// Token: 0x0401B90F RID: 112911
		[Token(Token = "0x401B90F")]
		[FieldOffset(Offset = "0x79")]
		private bool m_animEnableReverse;

		// Token: 0x0401B910 RID: 112912
		[Token(Token = "0x401B910")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__LoadBattleSpine;

		// Token: 0x0401B911 RID: 112913
		[Token(Token = "0x401B911")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__LoadBuildingSpine;

		// Token: 0x0401B912 RID: 112914
		[Token(Token = "0x401B912")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__LoadDynAvatarSpine;

		// Token: 0x0401B913 RID: 112915
		[Token(Token = "0x401B913")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0401B914 RID: 112916
		[Token(Token = "0x401B914")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderByAdapter;

		// Token: 0x0401B915 RID: 112917
		[Token(Token = "0x401B915")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ApplyTransform;

		// Token: 0x0401B916 RID: 112918
		[Token(Token = "0x401B916")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__LoadSpineGraphic;

		// Token: 0x0401B917 RID: 112919
		[Token(Token = "0x401B917")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__UpdateSpineAnimParam;

		// Token: 0x0401B918 RID: 112920
		[Token(Token = "0x401B918")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__ReleaseIfNot;

		// Token: 0x0401B919 RID: 112921
		[Token(Token = "0x401B919")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__EnableReverseMode;

		// Token: 0x0401B91A RID: 112922
		[Token(Token = "0x401B91A")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__DisableReverseMode;

		// Token: 0x0401B91B RID: 112923
		[Token(Token = "0x401B91B")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__ReverseMeshOrder;

		// Token: 0x0401B91C RID: 112924
		[Token(Token = "0x401B91C")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0401B91D RID: 112925
		[Token(Token = "0x401B91D")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0401B91E RID: 112926
		[Token(Token = "0x401B91E")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__InitSpineMaterial;

		// Token: 0x0401B91F RID: 112927
		[Token(Token = "0x401B91F")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__GenerateLoadSpineParam;

		// Token: 0x0401B920 RID: 112928
		[Token(Token = "0x401B920")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200385F RID: 14431
		[Token(Token = "0x200385F")]
		public enum PlayAnimOption
		{
			// Token: 0x0401B922 RID: 112930
			[Token(Token = "0x401B922")]
			LOOP,
			// Token: 0x0401B923 RID: 112931
			[Token(Token = "0x401B923")]
			PLAY_ONCE,
			// Token: 0x0401B924 RID: 112932
			[Token(Token = "0x401B924")]
			STOP
		}

		// Token: 0x02003860 RID: 14432
		[Token(Token = "0x2003860")]
		public enum SpineType
		{
			// Token: 0x0401B926 RID: 112934
			[Token(Token = "0x401B926")]
			CUSTOM,
			// Token: 0x0401B927 RID: 112935
			[Token(Token = "0x401B927")]
			BUILDING_CHAR,
			// Token: 0x0401B928 RID: 112936
			[Token(Token = "0x401B928")]
			BATTLE_CHAR,
			// Token: 0x0401B929 RID: 112937
			[Token(Token = "0x401B929")]
			DYN_AVATAR
		}

		// Token: 0x02003861 RID: 14433
		[Token(Token = "0x2003861")]
		public struct SpineID
		{
			// Token: 0x06016DBD RID: 93629 RVA: 0x00093510 File Offset: 0x00091710
			[Token(Token = "0x6016DBD")]
			[Address(RVA = "0xF5CEF0", Offset = "0xF5BAF0", VA = "0x180F5CEF0")]
			public bool Same(UISpineHolder.SpineID other)
			{
				return default(bool);
			}

			// Token: 0x0401B92A RID: 112938
			[Token(Token = "0x401B92A")]
			[FieldOffset(Offset = "0x0")]
			public string funcId;

			// Token: 0x0401B92B RID: 112939
			[Token(Token = "0x401B92B")]
			[FieldOffset(Offset = "0x8")]
			public UISpineHolder.SpineType type;
		}

		// Token: 0x02003862 RID: 14434
		[Token(Token = "0x2003862")]
		public struct SpineAnimParam
		{
			// Token: 0x0401B92C RID: 112940
			[Token(Token = "0x401B92C")]
			[FieldOffset(Offset = "0x0")]
			public string animName;

			// Token: 0x0401B92D RID: 112941
			[Token(Token = "0x401B92D")]
			[FieldOffset(Offset = "0x8")]
			public string defaultAnimName;

			// Token: 0x0401B92E RID: 112942
			[Token(Token = "0x401B92E")]
			[FieldOffset(Offset = "0x10")]
			public int startFramePercent;

			// Token: 0x0401B92F RID: 112943
			[Token(Token = "0x401B92F")]
			[FieldOffset(Offset = "0x14")]
			public UISpineHolder.PlayAnimOption animOption;
		}

		// Token: 0x02003863 RID: 14435
		[Token(Token = "0x2003863")]
		public enum LoadSpineMatOption
		{
			// Token: 0x0401B931 RID: 112945
			[Token(Token = "0x401B931")]
			KEEP,
			// Token: 0x0401B932 RID: 112946
			[Token(Token = "0x401B932")]
			USE_ALPHA_SPLIT
		}

		// Token: 0x02003864 RID: 14436
		[Token(Token = "0x2003864")]
		public struct SpineMatParam
		{
			// Token: 0x0401B933 RID: 112947
			[Token(Token = "0x401B933")]
			[FieldOffset(Offset = "0x0")]
			public Material material;

			// Token: 0x0401B934 RID: 112948
			[Token(Token = "0x401B934")]
			[FieldOffset(Offset = "0x8")]
			public UISpineHolder.LoadSpineMatOption option;
		}

		// Token: 0x02003865 RID: 14437
		[Token(Token = "0x2003865")]
		public struct LoadSpineParam
		{
			// Token: 0x0401B935 RID: 112949
			[Token(Token = "0x401B935")]
			[FieldOffset(Offset = "0x0")]
			public SkeletonDataAsset skeletonDataAsset;

			// Token: 0x0401B936 RID: 112950
			[Token(Token = "0x401B936")]
			[FieldOffset(Offset = "0x8")]
			public UISpineHolder.SpineMatParam spineMatParam;

			// Token: 0x0401B937 RID: 112951
			[Token(Token = "0x401B937")]
			[FieldOffset(Offset = "0x18")]
			public UISpineHolder.SpineAnimParam spineAnimParam;
		}

		// Token: 0x02003866 RID: 14438
		[Token(Token = "0x2003866")]
		public abstract class Adapter
		{
			// Token: 0x1700369C RID: 13980
			// (get) Token: 0x06016DBE RID: 93630 RVA: 0x00093528 File Offset: 0x00091728
			// (set) Token: 0x06016DBF RID: 93631 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700369C")]
			public Misc.TRS defaultTransform
			{
				[Token(Token = "0x6016DBE")]
				[Address(RVA = "0xF54880", Offset = "0xF53480", VA = "0x180F54880")]
				[CompilerGenerated]
				get
				{
					return default(Misc.TRS);
				}
				[Token(Token = "0x6016DBF")]
				[Address(RVA = "0xF54A60", Offset = "0xF53660", VA = "0x180F54A60")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x1700369D RID: 13981
			// (get) Token: 0x06016DC0 RID: 93632 RVA: 0x00093540 File Offset: 0x00091740
			// (set) Token: 0x06016DC1 RID: 93633 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700369D")]
			public float reverseModeAlpha
			{
				[Token(Token = "0x6016DC0")]
				[Address(RVA = "0x4E65D0", Offset = "0x4E51D0", VA = "0x1804E65D0")]
				get
				{
					return 0f;
				}
				[Token(Token = "0x6016DC1")]
				[Address(RVA = "0x4E65E0", Offset = "0x4E51E0", VA = "0x1804E65E0")]
				set
				{
				}
			}

			// Token: 0x06016DC2 RID: 93634
			[Token(Token = "0x6016DC2")]
			public abstract UISpineHolder.SpineID GetSpineID();

			// Token: 0x06016DC3 RID: 93635 RVA: 0x00093558 File Offset: 0x00091758
			[Token(Token = "0x6016DC3")]
			[Address(RVA = "0xF54880", Offset = "0xF53480", VA = "0x180F54880", Slot = "5")]
			public virtual Misc.TRS GetTransformParam()
			{
				return default(Misc.TRS);
			}

			// Token: 0x06016DC4 RID: 93636
			[Token(Token = "0x6016DC4")]
			public abstract UISpineHolder.SpineAnimParam GetAnimParam();

			// Token: 0x06016DC5 RID: 93637 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6016DC5")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "7")]
			public virtual UISpineHolder.CustomSpineLoader GetSpineLoader()
			{
				return null;
			}

			// Token: 0x06016DC6 RID: 93638 RVA: 0x00093570 File Offset: 0x00091770
			[Token(Token = "0x6016DC6")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "8")]
			public virtual bool EnableReverseMode(string animName)
			{
				return default(bool);
			}

			// Token: 0x06016DC7 RID: 93639 RVA: 0x00093588 File Offset: 0x00091788
			[Token(Token = "0x6016DC7")]
			[Address(RVA = "0xF549C0", Offset = "0xF535C0", VA = "0x180F549C0")]
			public bool NotifyRenderSpine()
			{
				return default(bool);
			}

			// Token: 0x06016DC8 RID: 93640 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016DC8")]
			[Address(RVA = "0xF548A0", Offset = "0xF534A0", VA = "0x180F548A0")]
			public void HolderOnly_Bind(UISpineHolder closure)
			{
			}

			// Token: 0x06016DC9 RID: 93641 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016DC9")]
			[Address(RVA = "0xF54940", Offset = "0xF53540", VA = "0x180F54940")]
			public void HolderOnly_Unbind(UISpineHolder closure)
			{
			}

			// Token: 0x06016DCA RID: 93642 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016DCA")]
			[Address(RVA = "0xF54A50", Offset = "0xF53650", VA = "0x180F54A50")]
			protected Adapter()
			{
			}

			// Token: 0x0401B938 RID: 112952
			[Token(Token = "0x401B938")]
			[FieldOffset(Offset = "0x10")]
			private float m_reverseModeAlpha;

			// Token: 0x0401B939 RID: 112953
			[Token(Token = "0x401B939")]
			[FieldOffset(Offset = "0x18")]
			private UISpineHolder m_closure;
		}

		// Token: 0x02003867 RID: 14439
		[Token(Token = "0x2003867")]
		public abstract class CustomSpineLoader
		{
			// Token: 0x06016DCB RID: 93643 RVA: 0x000935A0 File Offset: 0x000917A0
			[Token(Token = "0x6016DCB")]
			[Address(RVA = "0xF58F50", Offset = "0xF57B50", VA = "0x180F58F50")]
			public bool DoLoad(UISpineHolder.SpineID id, UISpineHolder holder)
			{
				return default(bool);
			}

			// Token: 0x06016DCC RID: 93644 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6016DCC")]
			protected T LoadAsset<T>(string path) where T : UnityEngine.Object
			{
				return null;
			}

			// Token: 0x06016DCD RID: 93645
			[Token(Token = "0x6016DCD")]
			protected abstract bool LoadImplement();

			// Token: 0x06016DCE RID: 93646
			[Token(Token = "0x6016DCE")]
			public abstract float GetSpineScale();

			// Token: 0x06016DCF RID: 93647
			[Token(Token = "0x6016DCF")]
			public abstract UnityEngine.Object GetAsset();

			// Token: 0x06016DD0 RID: 93648
			[Token(Token = "0x6016DD0")]
			public abstract SkeletonAnimation GetSkeletonAnim();

			// Token: 0x06016DD1 RID: 93649
			[Token(Token = "0x6016DD1")]
			public abstract SkeletonGraphic GetSkeletonGraphic();

			// Token: 0x06016DD2 RID: 93650 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016DD2")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			protected CustomSpineLoader()
			{
			}

			// Token: 0x0401B93B RID: 112955
			[Token(Token = "0x401B93B")]
			[FieldOffset(Offset = "0x10")]
			protected UISpineHolder.SpineID spineId;

			// Token: 0x0401B93C RID: 112956
			[Token(Token = "0x401B93C")]
			[FieldOffset(Offset = "0x20")]
			private UISpineHolder m_closure;
		}

		// Token: 0x02003868 RID: 14440
		[Token(Token = "0x2003868")]
		private struct SpineAsset : IHotfixable
		{
			// Token: 0x1700369E RID: 13982
			// (get) Token: 0x06016DD3 RID: 93651 RVA: 0x000935B8 File Offset: 0x000917B8
			// (set) Token: 0x06016DD4 RID: 93652 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700369E")]
			public UISpineHolder.SpineID id
			{
				[Token(Token = "0x6016DD3")]
				[Address(RVA = "0xF5C990", Offset = "0xF5B590", VA = "0x180F5C990")]
				[CompilerGenerated]
				readonly get
				{
					return default(UISpineHolder.SpineID);
				}
				[Token(Token = "0x6016DD4")]
				[Address(RVA = "0xF5CC10", Offset = "0xF5B810", VA = "0x180F5CC10")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x1700369F RID: 13983
			// (get) Token: 0x06016DD5 RID: 93653 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06016DD6 RID: 93654 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700369F")]
			public SkeletonAnimation skeletonAnim
			{
				[Token(Token = "0x6016DD5")]
				[Address(RVA = "0xF5CA70", Offset = "0xF5B670", VA = "0x180F5CA70")]
				[CompilerGenerated]
				readonly get
				{
					return null;
				}
				[Token(Token = "0x6016DD6")]
				[Address(RVA = "0xF5CD10", Offset = "0xF5B910", VA = "0x180F5CD10")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170036A0 RID: 13984
			// (get) Token: 0x06016DD7 RID: 93655 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06016DD8 RID: 93656 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170036A0")]
			public SkeletonGraphic skeletonGraphic
			{
				[Token(Token = "0x6016DD7")]
				[Address(RVA = "0xF5CB40", Offset = "0xF5B740", VA = "0x180F5CB40")]
				[CompilerGenerated]
				readonly get
				{
					return null;
				}
				[Token(Token = "0x6016DD8")]
				[Address(RVA = "0xF5CE00", Offset = "0xF5BA00", VA = "0x180F5CE00")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06016DD9 RID: 93657 RVA: 0x000935D0 File Offset: 0x000917D0
			[Token(Token = "0x6016DD9")]
			[Address(RVA = "0xF5C180", Offset = "0xF5AD80", VA = "0x180F5C180")]
			public float GetSpineScale()
			{
				return 0f;
			}

			// Token: 0x06016DDA RID: 93658 RVA: 0x000935E8 File Offset: 0x000917E8
			[Token(Token = "0x6016DDA")]
			[Address(RVA = "0xF5C250", Offset = "0xF5AE50", VA = "0x180F5C250")]
			public bool IsEmpty()
			{
				return default(bool);
			}

			// Token: 0x06016DDB RID: 93659 RVA: 0x00093600 File Offset: 0x00091800
			[Token(Token = "0x6016DDB")]
			[Address(RVA = "0xF5C3D0", Offset = "0xF5AFD0", VA = "0x180F5C3D0")]
			public static UISpineHolder.SpineAsset Load(UISpineHolder.SpineID id, UISpineHolder holder)
			{
				return default(UISpineHolder.SpineAsset);
			}

			// Token: 0x06016DDC RID: 93660 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016DDC")]
			[Address(RVA = "0xF5C770", Offset = "0xF5B370", VA = "0x180F5C770")]
			public void Unload(UISpineHolder holder)
			{
			}

			// Token: 0x0401B93D RID: 112957
			[Token(Token = "0x401B93D")]
			[FieldOffset(Offset = "0x0")]
			private float m_spineScale;

			// Token: 0x0401B941 RID: 112961
			[Token(Token = "0x401B941")]
			[FieldOffset(Offset = "0x28")]
			private UnityEngine.Object m_asset;

			// Token: 0x0401B942 RID: 112962
			[Token(Token = "0x401B942")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_id;

			// Token: 0x0401B943 RID: 112963
			[Token(Token = "0x401B943")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_id;

			// Token: 0x0401B944 RID: 112964
			[Token(Token = "0x401B944")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_skeletonAnim;

			// Token: 0x0401B945 RID: 112965
			[Token(Token = "0x401B945")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_set_skeletonAnim;

			// Token: 0x0401B946 RID: 112966
			[Token(Token = "0x401B946")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_skeletonGraphic;

			// Token: 0x0401B947 RID: 112967
			[Token(Token = "0x401B947")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_set_skeletonGraphic;

			// Token: 0x0401B948 RID: 112968
			[Token(Token = "0x401B948")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_GetSpineScale;

			// Token: 0x0401B949 RID: 112969
			[Token(Token = "0x401B949")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_IsEmpty;

			// Token: 0x0401B94A RID: 112970
			[Token(Token = "0x401B94A")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_Load;

			// Token: 0x0401B94B RID: 112971
			[Token(Token = "0x401B94B")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_Unload;
		}
	}
}
