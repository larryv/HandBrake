﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HBFunctions.cs" company="HandBrake Project (http://handbrake.fr)">
//   This file is part of the HandBrake source code - It may be used under the terms of the GNU General Public License.
// </copyright>
// <summary>
//   Defines the HBFunctions type.
// </summary>
// <auto-generated> Disable Stylecop Warnings for this file  </auto-generated>
// --------------------------------------------------------------------------------------------------------------------

namespace HandBrake.Interop.HbLib
{
	using System;
	using System.Runtime.InteropServices;

	/// <summary>
	/// Contains p-invoke function declarations to hblib.
	/// </summary>
	public static class HBFunctions
	{
		[DllImport("hb.dll", EntryPoint = "hb_register_logger", CallingConvention = CallingConvention.Cdecl)]
		public static extern void hb_register_logger(LoggingCallback callback);

		[DllImport("hb.dll", EntryPoint = "hb_register_error_handler", CallingConvention = CallingConvention.Cdecl)]
		public static extern void hb_register_error_handler(LoggingCallback callback);

		[DllImport("hb.dll", EntryPoint = "hb_global_init", CallingConvention = CallingConvention.Cdecl)]
		public static extern int hb_global_init();

		/// Return Type: hb_handle_t*
		///verbose: int
		///update_check: int
		[DllImport("hb.dll", EntryPoint = "hb_init", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr hb_init(int verbose, int update_check);


		/// Return Type: hb_handle_t*
		///verbose: int
		///update_check: int
		[DllImport("hb.dll", EntryPoint = "hb_init_dl", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr hb_init_dl(int verbose, int update_check);


		/// Return Type: char*
		///param0: hb_handle_t*
		[DllImport("hb.dll", EntryPoint = "hb_get_version", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr hb_get_version(IntPtr hbHandle);


		/// Return Type: int
		///param0: hb_handle_t*
		[DllImport("hb.dll", EntryPoint = "hb_get_build", CallingConvention = CallingConvention.Cdecl)]
		public static extern int hb_get_build(IntPtr hbHandle);


		/// Return Type: int
		///h: hb_handle_t*
		///version: char**
		[DllImport("hb.dll", EntryPoint = "hb_check_update", CallingConvention = CallingConvention.Cdecl)]
		public static extern int hb_check_update(IntPtr handle, ref IntPtr version);


		/// Return Type: char*
		///path: char*
		[DllImport("hb.dll", EntryPoint = "hb_dvd_name", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr hb_dvd_name(IntPtr path);


		/// Return Type: void
		///enable: int
		[DllImport("hb.dll", EntryPoint = "hb_dvd_set_dvdnav", CallingConvention = CallingConvention.Cdecl)]
		public static extern void hb_dvd_set_dvdnav(int enable);


		/// Return Type: void
		///param0: hb_handle_t*
		///path: char*
		///title_index: int
		///preview_count: int
		///store_previews: int
		[DllImport("hb.dll", EntryPoint = "hb_scan", CallingConvention = CallingConvention.Cdecl)]
		public static extern void hb_scan(IntPtr hbHandle, IntPtr path, int title_index, int preview_count, int store_previews, ulong min_duration);

		[DllImport("hb.dll", EntryPoint = "hb_scan_stop", CallingConvention = CallingConvention.Cdecl)]
		public static extern void hb_scan_stop(IntPtr hbHandle);

		/// Return Type: hb_list_t*
		///param0: hb_handle_t*
		[DllImport("hb.dll", EntryPoint = "hb_get_titles", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr hb_get_titles(IntPtr hbHandle);

		/// Return Type: void
		///param0: hb_handle_t*
		///param1: hb_title_t*
		///param2: int
		///param3: uint8_t*
		[DllImport("hb.dll", EntryPoint = "hb_get_preview", CallingConvention = CallingConvention.Cdecl)]
		public static extern void hb_get_preview(IntPtr hbHandle, ref hb_job_s title, int preview, IntPtr buffer);


		/// Return Type: void
		///param0: hb_job_t*
		///ratio: double
		///pixels: int
		[DllImport("hb.dll", EntryPoint = "hb_set_size", CallingConvention = CallingConvention.Cdecl)]
		public static extern void hb_set_size(ref hb_job_s param0, double ratio, int pixels);

		/// Return Type: void
		///param0: hb_job_t*
		///output_width: int*
		///output_height: int*
		///output_par_width: int*
		///output_par_height: int*
		[DllImport("hb.dll", EntryPoint = "hb_set_anamorphic_size", CallingConvention = CallingConvention.Cdecl)]
		public static extern void hb_set_anamorphic_size(ref hb_job_s job, ref int output_width, ref int output_height, ref int output_par_width, ref int output_par_height);


		/// Return Type: int
		///param0: hb_handle_t*
		[DllImport("hb.dll", EntryPoint = "hb_count", CallingConvention = CallingConvention.Cdecl)]
		public static extern int hb_count(IntPtr hbHandle);


		/// Return Type: hb_job_t*
		///param0: hb_handle_t*
		///param1: int
		[DllImport("hb.dll", EntryPoint = "hb_job", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr hb_job(IntPtr hbHandle, int jobIndex);

		[DllImport("hb.dll", EntryPoint = "hb_set_job", CallingConvention = CallingConvention.Cdecl)]
		public static extern void hb_set_job(IntPtr hbHandle, int title_index, ref hb_job_s job);

		/// Return Type: void
		///param0: hb_handle_t*
		///param1: hb_job_t*
		[DllImport("hb.dll", EntryPoint = "hb_add", CallingConvention = CallingConvention.Cdecl)]
		public static extern void hb_add(IntPtr hbHandle, ref hb_job_s job);


		/// Return Type: void
		///param0: hb_handle_t*
		///param1: hb_job_t*
		[DllImport("hb.dll", EntryPoint = "hb_rem", CallingConvention = CallingConvention.Cdecl)]
		public static extern void hb_rem(IntPtr hbHandle, IntPtr job);


		/// Return Type: void
		///param0: hb_handle_t*
		[DllImport("hb.dll", EntryPoint = "hb_start", CallingConvention = CallingConvention.Cdecl)]
		public static extern void hb_start(IntPtr hbHandle);


		/// Return Type: void
		///param0: hb_handle_t*
		[DllImport("hb.dll", EntryPoint = "hb_pause", CallingConvention = CallingConvention.Cdecl)]
		public static extern void hb_pause(IntPtr hbHandle);


		/// Return Type: void
		///param0: hb_handle_t*
		[DllImport("hb.dll", EntryPoint = "hb_resume", CallingConvention = CallingConvention.Cdecl)]
		public static extern void hb_resume(IntPtr hbHandle);


		/// Return Type: void
		///param0: hb_handle_t*
		[DllImport("hb.dll", EntryPoint = "hb_stop", CallingConvention = CallingConvention.Cdecl)]
		public static extern void hb_stop(IntPtr hbHandle);

		/// Return Type: void
		///param0: hb_handle_t*
		///param1: hb_state_t*
		[DllImport("hb.dll", EntryPoint = "hb_get_state", CallingConvention = CallingConvention.Cdecl)]
		public static extern void hb_get_state(IntPtr hbHandle, ref hb_state_s state);


		/// Return Type: void
		///param0: hb_handle_t*
		///param1: hb_state_t*
		[DllImport("hb.dll", EntryPoint = "hb_get_state2", CallingConvention = CallingConvention.Cdecl)]
		public static extern void hb_get_state2(IntPtr hbHandle, ref hb_state_s param1);


		/// Return Type: int
		///param0: hb_handle_t*
		[DllImport("hb.dll", EntryPoint = "hb_get_scancount", CallingConvention = CallingConvention.Cdecl)]
		public static extern int hb_get_scancount(IntPtr hbHandle);


		/// Return Type: void
		///param0: hb_handle_t**
		[DllImport("hb.dll", EntryPoint = "hb_close", CallingConvention = CallingConvention.Cdecl)]
		public static extern void hb_close(IntPtr hbHandle);

		[DllImport("hb.dll", EntryPoint = "hb_global_close", CallingConvention = CallingConvention.Cdecl)]
		public static extern void hb_global_close();

		//hb_list_t * hb_list_init();
		[DllImport("hb.dll", EntryPoint = "hb_list_init", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr hb_list_init();

		//int         hb_list_count( const hb_list_t * );
		[DllImport("hb.dll", EntryPoint = "hb_list_count", CallingConvention = CallingConvention.Cdecl)]
		public static extern int hb_list_count(IntPtr listPtr);

		//void        hb_list_add( hb_list_t *, void * );
		[DllImport("hb.dll", EntryPoint = "hb_list_add", CallingConvention = CallingConvention.Cdecl)]
		public static extern void hb_list_add(IntPtr listPtr, IntPtr item);

		//void        hb_list_insert( hb_list_t * l, int pos, void * p );
		[DllImport("hb.dll", EntryPoint = "hb_list_insert", CallingConvention = CallingConvention.Cdecl)]
		public static extern void hb_list_insert(IntPtr listPtr, int pos, IntPtr item);

		//void        hb_list_rem( hb_list_t *, void * );
		[DllImport("hb.dll", EntryPoint = "hb_list_rem", CallingConvention = CallingConvention.Cdecl)]
		public static extern void hb_list_rem(IntPtr listPtr, IntPtr item);

		//void      * hb_list_item( const hb_list_t *, int );
		[DllImport("hb.dll", EntryPoint = "hb_list_item", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr hb_list_item(IntPtr listPtr, int itemIndex);

		//void        hb_list_close( hb_list_t ** );
		[DllImport("hb.dll", EntryPoint = "hb_list_close", CallingConvention = CallingConvention.Cdecl)]
		public static extern void hb_list_close(IntPtr listPtrPtr);


		[DllImport("hb.dll", EntryPoint = "hb_subtitle_add", CallingConvention = CallingConvention.Cdecl)]
		public static extern int hb_subtitle_add(ref hb_job_s job, ref hb_subtitle_config_s subtitleConfig, int track);

		[DllImport("hb.dll", EntryPoint = "hb_srt_add", CallingConvention = CallingConvention.Cdecl)]
		public static extern int hb_srt_add(ref hb_job_s job, ref hb_subtitle_config_s subtitleConfig, string lang);

		[DllImport("hb.dll", EntryPoint = "hb_subtitle_can_force", CallingConvention = CallingConvention.Cdecl)]
		public static extern int hb_subtitle_can_force(int source);

		[DllImport("hb.dll", EntryPoint = "hb_subtitle_can_burn", CallingConvention = CallingConvention.Cdecl)]
		public static extern int hb_subtitle_can_burn(int source);

		[DllImport("hb.dll", EntryPoint = "hb_subtitle_can_pass", CallingConvention = CallingConvention.Cdecl)]
		public static extern int hb_subtitle_can_pass(int source, int mux);



//int              hb_video_framerate_get_from_name(const char *name);
//const char*      hb_video_framerate_get_name(int framerate);
//const char*      hb_video_framerate_sanitize_name(const char *name);

		// returns hb_rate_s
		[DllImport("hb.dll", EntryPoint = "hb_video_framerate_get_next", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr hb_video_framerate_get_next(IntPtr last);


//int              hb_audio_samplerate_get_best(uint32_t codec, int samplerate, int *sr_shift);
//int              hb_audio_samplerate_get_from_name(const char *name);
//const char*      hb_audio_samplerate_get_name(int samplerate);

		// returns hb_rate_s
		[DllImport("hb.dll", EntryPoint = "hb_audio_samplerate_get_next", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr hb_audio_samplerate_get_next(IntPtr last);


		[DllImport("hb.dll", EntryPoint = "hb_audio_bitrate_get_best", CallingConvention = CallingConvention.Cdecl)]
		public static extern int hb_audio_bitrate_get_best(uint codec, int bitrate, int samplerate, int mixdown);

		[DllImport("hb.dll", EntryPoint = "hb_audio_bitrate_get_default", CallingConvention = CallingConvention.Cdecl)]
		public static extern int hb_audio_bitrate_get_default(uint codec, int samplerate, int mixdown);

		[DllImport("hb.dll", EntryPoint = "hb_audio_bitrate_get_limits", CallingConvention = CallingConvention.Cdecl)]
		public static extern int hb_audio_bitrate_get_limits(uint codec, int samplerate, int mixdown, ref int low, ref int high);

		[DllImport("hb.dll", EntryPoint = "hb_audio_bitrate_get_next", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr hb_audio_bitrate_get_next(IntPtr last);

		[DllImport("hb.dll", EntryPoint = "hb_video_quality_get_limits", CallingConvention = CallingConvention.Cdecl)]
		public static extern void hb_video_quality_get_limits(uint codec, ref float low, ref float high, ref float granularity, ref int direction);

		[DllImport("hb.dll", EntryPoint = "hb_video_quality_get_name", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr hb_video_quality_get_name(uint codec);

		[DllImport("hb.dll", EntryPoint = "hb_audio_quality_get_limits", CallingConvention = CallingConvention.Cdecl)]
		public static extern void hb_audio_quality_get_limits(uint codec, ref float low, ref float high, ref float granularity, ref int direction);

//float hb_audio_quality_get_best(uint32_t codec, float quality);

		[DllImport("hb.dll", EntryPoint = "hb_audio_quality_get_default", CallingConvention = CallingConvention.Cdecl)]
		public static extern float hb_audio_quality_get_default(uint codec);


		[DllImport("hb.dll", EntryPoint = "hb_audio_compression_get_limits", CallingConvention = CallingConvention.Cdecl)]
		public static extern void hb_audio_compression_get_limits(uint codec, ref float low, ref float high, ref float granularity, ref int direction);

//float hb_audio_compression_get_best(uint32_t codec, float compression);

		[DllImport("hb.dll", EntryPoint = "hb_audio_compression_get_default", CallingConvention = CallingConvention.Cdecl)]
		public static extern float hb_audio_compression_get_default(uint codec);


//int                hb_audio_dither_get_default();
//int                hb_audio_dither_get_default_method(); // default method, if enabled && supported
//int                hb_audio_dither_is_supported(uint32_t codec);
//int                hb_audio_dither_get_from_name(const char *name);
//const char*        hb_audio_dither_get_description(int method);
//const hb_dither_t* hb_audio_dither_get_next(const hb_dither_t *last);

		[DllImport("hb.dll", EntryPoint = "hb_audio_can_apply_drc", CallingConvention = CallingConvention.Cdecl)]
		public static extern int hb_audio_can_apply_drc(uint codec, uint codec_param, int encoder);

		[DllImport("hb.dll", EntryPoint = "hb_mixdown_is_supported", CallingConvention = CallingConvention.Cdecl)]
		public static extern int hb_mixdown_is_supported(int mixdown, uint codec, ulong layout);

		[DllImport("hb.dll", EntryPoint = "hb_mixdown_has_codec_support", CallingConvention = CallingConvention.Cdecl)]
		public static extern int hb_mixdown_has_codec_support(int mixdown, uint codec);

		[DllImport("hb.dll", EntryPoint = "hb_mixdown_has_remix_support", CallingConvention = CallingConvention.Cdecl)]
		public static extern int hb_mixdown_has_remix_support(int mixdown, ulong layout);

//int                 hb_mixdown_get_discrete_channel_count(int mixdown);
//int                 hb_mixdown_get_low_freq_channel_count(int mixdown);

		[DllImport("hb.dll", EntryPoint = "hb_mixdown_get_best", CallingConvention = CallingConvention.Cdecl)]
		public static extern int hb_mixdown_get_best(uint codec, ulong layout, int mixdown);

		[DllImport("hb.dll", EntryPoint = "hb_mixdown_get_default", CallingConvention = CallingConvention.Cdecl)]
		public static extern int hb_mixdown_get_default(uint codec, ulong layout);

//int                 hb_mixdown_get_from_name(const char *name);
//const char*         hb_mixdown_get_name(int mixdown);
//const char*         hb_mixdown_get_short_name(int mixdown);
//const char*         hb_mixdown_sanitize_name(const char *name);

		[DllImport("hb.dll", EntryPoint = "hb_mixdown_get_next", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr hb_mixdown_get_next(IntPtr last);

//int                 hb_video_encoder_get_default(int muxer);
//int                 hb_video_encoder_get_from_name(const char *name);
//const char*         hb_video_encoder_get_name(int encoder);
//const char*         hb_video_encoder_get_short_name(int encoder);
//const char*         hb_video_encoder_get_long_name(int encoder);
//const char*         hb_video_encoder_sanitize_name(const char *name);

		[DllImport("hb.dll", EntryPoint = "hb_video_encoder_get_next", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr hb_video_encoder_get_next(IntPtr last);

/*
 * hb_audio_encoder_get_fallback_for_passthru() will sanitize a passthru codec
 * to the matching audio encoder (if any is available).
 *
 * hb_audio_encoder_get_from_name(), hb_audio_encoder_sanitize_name() will
 * sanitize legacy encoder names, but won't convert passthru to an encoder.
 */
//int                 hb_audio_encoder_get_fallback_for_passthru(int passthru);
//int                 hb_audio_encoder_get_default(int muxer);
//int                 hb_audio_encoder_get_from_name(const char *name);
//const char*         hb_audio_encoder_get_name(int encoder);
//const char*         hb_audio_encoder_get_short_name(int encoder);
//const char*         hb_audio_encoder_get_long_name(int encoder);
//const char*         hb_audio_encoder_sanitize_name(const char *name);

		[DllImport("hb.dll", EntryPoint = "hb_audio_encoder_get_next", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr hb_audio_encoder_get_next(IntPtr last);

//int                   hb_container_get_from_name(const char *name);
//int                   hb_container_get_from_extension(const char *extension); // not really a container name
//const char*           hb_container_get_name(int format);
//const char*           hb_container_get_short_name(int format);
//const char*           hb_container_get_long_name(int format);
//const char*           hb_container_get_default_extension(int format);
//const char*           hb_container_sanitize_name(const char *name);

		[DllImport("hb.dll", EntryPoint = "hb_container_get_from_name", CallingConvention = CallingConvention.Cdecl)]
		public static extern int hb_container_get_from_name([In] [MarshalAs(UnmanagedType.LPStr)] string name);

		[DllImport("hb.dll", EntryPoint = "hb_container_get_next", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr hb_container_get_next(IntPtr last);

		[DllImport("hb.dll", EntryPoint = "lang_get_next", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr lang_get_next(IntPtr last);

		[DllImport("hb.dll", EntryPoint = "lang_for_code2", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr lang_for_code2([In] [MarshalAs(UnmanagedType.LPStr)] string code2);





		/// void hb_autopassthru_apply_settings( hb_job_t * job )
		[DllImport("hb.dll", EntryPoint = "hb_autopassthru_apply_settings", CallingConvention = CallingConvention.Cdecl)]
		public static extern void hb_autopassthru_apply_settings(ref hb_job_s job);

		///hb_title_set_t  * hb_get_title_set( hb_handle_t * );
		[DllImport("hb.dll", EntryPoint = "hb_get_title_set", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr hb_get_title_set(IntPtr hbHandle);

		///hb_job_t * hb_job_init_by_index( hb_handle_t *h, int title_index );
		[DllImport("hb.dll", EntryPoint = "hb_job_init_by_index", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr hb_job_init_by_index(IntPtr hbHandle, int title_index);

		///hb_job_t * hb_job_init( hb_title_t * title );
		[DllImport("hb.dll", EntryPoint = "hb_job_init", CallingConvention = CallingConvention.Cdecl)]
		public static extern hb_job_s hb_job_init(ref hb_title_s title);

		///void hb_job_reset( hb_job_t * job );
		[DllImport("hb.dll", EntryPoint = "hb_job_reset", CallingConvention = CallingConvention.Cdecl)]
		public static extern void hb_job_reset(ref hb_job_s job);

		///void hb_job_close( hb_job_t ** job );
		[DllImport("hb.dll", EntryPoint = "hb_job_close", CallingConvention = CallingConvention.Cdecl)]
		public static extern void hb_job_close(IntPtr job);

		///void hb_job_set_advanced_opts( hb_job_t *job, const char *advanced_opts );
		[DllImport("hb.dll", EntryPoint = "hb_job_set_advanced_opts", CallingConvention = CallingConvention.Cdecl)]
		public static extern void hb_job_set_advanced_opts(ref hb_job_s job, IntPtr advanced_opts);

		///void hb_job_set_file( hb_job_t *job, const char *file );
		[DllImport("hb.dll", EntryPoint = "hb_job_set_file", CallingConvention = CallingConvention.Cdecl)]
		public static extern void hb_job_set_file(ref hb_job_s job, IntPtr file);

		///void hb_chapter_set_title(hb_chapter_t *chapter, const char *title);
		[DllImport("hb.dll", EntryPoint = "hb_chapter_set_title", CallingConvention = CallingConvention.Cdecl)]
		public static extern void hb_chapter_set_title(IntPtr chapter, [In] [MarshalAs(UnmanagedType.LPStr)] string title);

		///void hb_chapter_set_title(hb_chapter_t *chapter, const char *title);
		[DllImport("hb.dll", EntryPoint = "hb_chapter_set_title", CallingConvention = CallingConvention.Cdecl)]
		public static extern void hb_chapter_set_title__ptr(IntPtr chapter, IntPtr title);

		/// void hb_add_filter( hb_job_t * job, hb_filter_object_t * filter, const char * settings ); 
		[DllImport("hb.dll", EntryPoint = "hb_add_filter", CallingConvention = CallingConvention.Cdecl)]
		public static extern void hb_add_filter(ref hb_job_s job, ref hb_filter_object_s filter, IntPtr settings);

		/// hb_filter_object_t * hb_filter_init( int filter_id );
		[DllImport("hb.dll", EntryPoint = "hb_filter_init", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr hb_filter_init(int filter_id);

		[DllImport("hb.dll", EntryPoint = "hb_x264_encopt_name", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr hb_x264_encopt_name(IntPtr name);

		[DllImport("hb.dll", EntryPoint = "hb_check_h264_level", CallingConvention = CallingConvention.Cdecl)]
		public static extern int hb_check_h264_level([In] [MarshalAs(UnmanagedType.LPStr)] string level, int width, int height, int fps_num, int fps_den, int interlaced, int fake_interlaced);

		[DllImport("hb.dll", EntryPoint = "hb_x264_param_unparse", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr hb_x264_param_unparse(
			[In] [MarshalAs(UnmanagedType.LPStr)] string x264_preset,
			[In] [MarshalAs(UnmanagedType.LPStr)] string x264_tune,
			[In] [MarshalAs(UnmanagedType.LPStr)] string x264_encopts,
			[In] [MarshalAs(UnmanagedType.LPStr)] string x264_profile,
			[In] [MarshalAs(UnmanagedType.LPStr)] string h264_level,
			int width,
			int height);


		[DllImport("hb.dll", EntryPoint = "hb_get_opencl_env", CallingConvention = CallingConvention.Cdecl)]
		public static extern int hb_get_opencl_env();

		[DllImport("hb.dll", EntryPoint = "hb_qsv_available", CallingConvention = CallingConvention.Cdecl)]
		public static extern int hb_qsv_available();
		
		[DllImport("hb.dll", EntryPoint = "hb_qsv_info_init", CallingConvention = CallingConvention.Cdecl)]
		public static extern int hb_qsv_info_init();
	}
}
