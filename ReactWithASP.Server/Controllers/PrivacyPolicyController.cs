﻿//using Ganss.Xss;

        [HttpPost("SavePrivacyPolicy")]
        public async Task<IActionResult> GetPrivacyPolicyInfo()
        {
            var data = await _context.PrivacyPolicy.ToListAsync();
            return Ok(data);
        }