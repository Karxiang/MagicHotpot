using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FullSD.Server.Data;
using FullSD.Shared.Domain;
using FullSD.Server.IRepository;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace FullSD.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BranchesController : ControllerBase
    {
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        //public BranchesController(ApplicationDbContext context)
        public BranchesController(IUnitOfWork unitOfWork)
        {
            //_context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/Branches
        [HttpGet]
        //public async Task<ActionResult<IEnumerable<Branch>>> GetBranches()
        public async Task<IActionResult> GetBranches()
        {

            //return await _context.Branches.ToListAsync();
            var branches = await _unitOfWork.Branches.GetAll();
            return Ok(branches);
        }

        // GET: api/Branches/5
        [HttpGet("{id}")]
        //public async Task<ActionResult<Branch>> GetBranch(int id)
        public async Task<IActionResult> GetBranch(int id)
        {
            //var branch = await _context.Branches.FindAsync(id);
            var branch = await _unitOfWork.Branches.Get(q => q.Id == id);
            if (branch == null)
            {
                return NotFound();
            }

            return Ok(branch);
        }

        // PUT: api/Branches/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBranch(int id, Branch branch)
        {
            if (id != branch.Id)
            {
                return BadRequest();
            }

            //_context.Entry(branch).State = EntityState.Modified;
            _unitOfWork.Branches.Update(branch);
            try
            {
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //if (!BranchExists(id))
                if (!await BranchExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Branches
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Branch>> PostBranch(Branch branch)
        {
            //_context.Branches.Add(branch);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Branches.Insert(branch);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetBranch", new { id = branch.Id }, branch);
        }

        // DELETE: api/Branches/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBranch(int id)
        {

            //var branch = await _context.Branches.FindAsync(id);
            var branch = await _unitOfWork.Branches.Get(q => q.Id == id);
            if (branch == null)
            {
                return NotFound();
            }

            //_context.Branches.Remove(branch);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Branches.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //private bool BranchExists(int id)
        private async Task<bool> BranchExists(int id)
        {
            //return (_context.Branches?.Any(e => e.Id == id)).GetValueOrDefault();
            var branch = await _unitOfWork.Branches.Get(q => q.Id == id);
            return branch != null;
        }
    }
}
